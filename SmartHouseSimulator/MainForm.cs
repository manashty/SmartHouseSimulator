using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace SmartHouseSimulator
{
    public partial class MainForm : Form
    {
        enum DrawType
        {
            Line, Rectangle, Item, Select, None
        }
        Boolean drawStarted;
        DrawType currentDrawType = DrawType.None;
        Graphics g;

        //delegate 


        //Point firstClickedPoint;
        //Point lastClickedPoint;

        //------------------------Simulating Time-----------------------------
        DateTime simulatedTime;
        Boolean useRealTime=true;
       

        public static List<Schedule> ScheduleTasks = new List<Schedule>();

        public static List<Condition> listOfConditiones = new List<Condition>();// added conditions
        public static List<Condition> listOfScenarioConditions = new List<Condition>();// conditions which assign to a scenario

        List<Point> lineList = new List<Point>();
        List<Point> rectangleList = new List<Point>();

        public static List<HouseObject> AddedHouseObjects = new List<HouseObject>();// simulated objects
        public static List<HouseObject> houseObjectsList = new List<HouseObject>();//simulated objects which use in house plan in designing form

        int selectedItemRadius = 20;  //Drawing a rectangle around the selected item

        int selectedItemindex = -1;        //get index of selected item in ObjectList = i

        int selectedMovingItemIndex = -1;
        int with;
        int height;
        string serverAddress = @"http://localhost:1316/MobileServer.aspx?";
        //string serverAddress = @"http://localhost:1076/MobileServer.aspx?";
        private bool LoadDefaultSensors=false;
        public MainForm()
        {

            //if (chbox_SimulatedTime.Checked==true)
            //    useRealTime = false;
            //else useRealTime = true;
            // Form LoginForm = new Login(this);
            //LoginForm.Show();
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            c = this.Cursor;
            with = pictureBox1.Width;
            height = pictureBox1.Height;
            AddObject.ObjectChanged += new EventHandler(AddObject_ObjectChanged);
            Sensor.SensorDataChanged += new EventHandler(Sensor_SensorDataChanged);
            sensorUpdateQueue = new Queue<KeyValuePair<string, string>>();
        }

        Queue<KeyValuePair<string, string>> sensorUpdateQueue;
        void Sensor_SensorDataChanged(object sender, EventArgs e)
        {            
            sensorUpdateQueue.Enqueue((KeyValuePair<string, string>)sender);
        }
        void AddObject_ObjectChanged(object sender, EventArgs e)
        {
            ShowHouseObjectsIcon();
        }

        void AddObject_ObjectChanged(int numberOfObjects)
        {
            ShowHouseObjectsIcon();
        }

        //---------Saving A picture of house plan with out its Icons------------

        public void DrawElements()
        {
            Bitmap HouseBackground = new Bitmap(with, height, g);
            Graphics gImage = Graphics.FromImage(HouseBackground);


            g.Clear(pictureBox1.BackColor);
            gImage.DrawImage(HousePlan,


                0, 0);
            for (int i = 0; i < lineList.Count; i += 2)  //Draw line
            {
                // g.DrawLine(new Pen(Color.Black), lineList[i], lineList[i + 1]);
                gImage.DrawLine(new Pen(Color.Black), lineList[i], lineList[i + 1]);

            }
            for (int i = 0; i < rectangleList.Count; i += 2)  //Draw Rectangle
            {
                //g.DrawRectangle(new Pen(Color.Black), rectangleList[i].X, rectangleList[i].Y, rectangleList[i + 1].X - rectangleList[i].X, rectangleList[i + 1].Y - rectangleList[i].Y);
                gImage.DrawRectangle(new Pen(Color.Black), rectangleList[i].X, rectangleList[i].Y, rectangleList[i + 1].X - rectangleList[i].X, rectangleList[i + 1].Y - rectangleList[i].Y);
            }
            g.DrawImage(HouseBackground, 0, 0);
            for (int i = 0; i < houseObjectsList.Count; i++)
            {
                //g.DrawImage(imageList1.Images[listView1.SelectedItems[0].ImageIndex], e.Location);
                //g.DrawImage(imageList1.Images[houseObjectsList[i].itemIndex], houseObjectsList[i].itemPosition);
                g.DrawImage(imageList1.Images[houseObjectsList[i].itemIndex], houseObjectsList[i].itemPosition.X - imageList1.Images[houseObjectsList[i].itemIndex].Width / 2, houseObjectsList[i].itemPosition.Y - imageList1.Images[houseObjectsList[i].itemIndex].Height / 2);

            }
            gImage.Flush();
            //Bitmap SavingHouseBackground = new Bitmap(HouseBackground);
            //(new Thread(new ParameterizedThreadStart(SaveImage))).Start(HouseBackground);

        }

        static bool isSaving = false;
        static void SaveImage(Object b)
        {
            Bitmap SavingHouseBackground = new Bitmap(b as Bitmap);
            if (isSaving)
                return;
            isSaving = true;
            SavingHouseBackground.Save("C:\\HouseBackground.jpg");
            isSaving = false;
        }

        private void listView1_DragLeave(object sender, EventArgs e)
        {
            //listView1.DoDragDrop(imageList1.Images[listView1.SelectedItems[0].ImageIndex], DragDropEffects.Copy);
            Bitmap b = new Bitmap(imageList1.Images[listView1.SelectedItems[0].ImageIndex]);
            this.Cursor = CreateCursor(b, 3, 3);
        }

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IconInfo tmp = new IconInfo();
            GetIconInfo(bmp.GetHicon(), ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            return new Cursor(CreateIconIndirect(ref tmp));
        }
        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDrawType = DrawType.Item;
            if (listView1.SelectedItems.Count > 0)
            {
                Bitmap b = new Bitmap(imageList1.Images[listView1.SelectedItems[0].ImageIndex]);
                pictureBox1.Cursor = CreateCursor(b, b.Width / 2, b.Height / 2);
            }//pictureBox1.Cursor=
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentDrawType == DrawType.Select)
            {
                String status = "";
                HouseObject currentObject = houseObjectsList[selectedItemindex];

                for (int i = 0; i < currentObject.sensors.Count; i++)
                {
                    Sensor currentSensor = currentObject.sensors[i];
                    status += currentSensor.GetStatus() + "\n";
                }
                toolTip_showStatus.Show(status, pictureBox1, currentObject.itemPosition.X, currentObject.itemPosition.Y, 5000);
               
               // toolTip_showStatus.SetToolTip(new Control("", currentObject.itemPosition.X, currentObject.itemPosition.Y, 5, 5), status);
            }
            //selectedMovingItemIndex = -1;
            if (e.Button == MouseButtons.Right)
            {
                if (selectedItemindex != -1)
                {
                    pictureBox1.ContextMenuStrip = contextMenuStrip1;
                }
                else
                    pictureBox1.ContextMenuStrip = null;

            }
            else
            {
                this.Cursor = c;
                //listView1.clea
            }
            if (e.Button == MouseButtons.Left)
            {
                if (currentDrawType == DrawType.Item)
                    if (listView1.SelectedItems.Count != 0)
                    {
                        string name = Microsoft.VisualBasic.Interaction.InputBox("Enter Object's Name:", "Object's Name", "New"
                            + AddedHouseObjects[listView1.SelectedIndices[0]].houseObjectName, 100, 100);
                        List<Sensor> sensors = new List<Sensor>();// (AddedHouseObjects[listView1.SelectedIndices[0]].sensors);
                        foreach (Sensor s in AddedHouseObjects[listView1.SelectedIndices[0]].sensors)
                        {
                            s.name = name + "_" + s.name;//Add the object name's prefix to each sensorname
                            sensors.Add(new Sensor(s));
                        }

                        houseObjectsList.Add(new HouseObject(e.Location,
                            name != "" ? name : "New" + AddedHouseObjects[listView1.SelectedIndices[0]].houseObjectName,
                            sensors,
                            AddedHouseObjects[listView1.SelectedIndices[0]].itemIndex));
                    }
            }

            DrawElements();


        }

        private void toolStripButton_DrawLine_Click(object sender, EventArgs e)
        {
            currentDrawType = DrawType.Line;
            pictureBox1.Cursor = c;
            toolStripButton_Rectangle.Checked = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            drawStarted = true;

            switch (currentDrawType)
            {
                case DrawType.Line:

                    lineList.Add(e.Location);
                    lineList.Add(e.Location);
                    break;
                case DrawType.Rectangle:
                    rectangleList.Add(e.Location);
                    rectangleList.Add(e.Location);
                    break;
                case DrawType.Item:
                    break;
                case DrawType.Select:
                    break;
                case DrawType.None:
                    break;
                default:
                    break;
            }
            //select an item
            if (currentDrawType == DrawType.Select)
            {
                for (int i = 0; i < houseObjectsList.Count; i++)
                {
                    if ((Math.Pow(e.X - houseObjectsList[i].itemPosition.X, 2) + Math.Pow(e.Y - houseObjectsList[i].itemPosition.Y, 2)) < Math.Pow(selectedItemRadius, 2))
                    {
                        selectedMovingItemIndex = selectedItemindex = i;
                        // MessageBox.Show("Item Selected");
                        g.DrawRectangle(new Pen(Color.Gray), houseObjectsList[i].itemPosition.X - imageList1.Images[houseObjectsList[i].itemIndex].Width / 2, houseObjectsList[i].itemPosition.Y - imageList1.Images[houseObjectsList[i].itemIndex].Height / 2, imageList1.Images[houseObjectsList[i].itemIndex].Width, imageList1.Images[houseObjectsList[i].itemIndex].Height);
                        break;
                    }

                }
            }
            //g.DrawLine(new Pen(Color.Black),lineList[0],lineList[1]);

            if (e.Button == MouseButtons.Right)
            {
                if (selectedMovingItemIndex != -1)
                {
                    pictureBox1.ContextMenuStrip = contextMenuStrip1;
                }
                else
                    pictureBox1.ContextMenuStrip = null;
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //String status = "";
            //HouseObject currentObject = houseObjectsList[selectedItemindex];

            //for (int i = 0; i < currentObject.sensors.Count; i++)
            //{
            //    Sensor currentSensor = currentObject.sensors[i];
            //    status += currentSensor.GetStatus() + "\n";
            //}
            //toolTip_showStatus.SetToolTip(new Control("",currentObject.itemPosition.X,currentObject.itemPosition.Y,5,5),status);
            if (drawStarted)
            {
                switch (currentDrawType)
                {
                    case DrawType.Line:
                        lineList[lineList.Count - 1] = e.Location;
                        break;
                    case DrawType.Rectangle:
                        rectangleList[rectangleList.Count - 1] = e.Location;
                        break;
                    case DrawType.Item:
                        break;
                    case DrawType.None:
                        break;
                    default:
                        break;
                }

                DrawElements();

            }
            if (e.Button == MouseButtons.Left)
            {
                if (currentDrawType == DrawType.Select)
                    if (selectedMovingItemIndex != -1)
                    {
                        //g.DrawImage(imageList1.Images[houseObjectsList[selectedItemindex].itemIndex], e.X, e.Y);
                        houseObjectsList[selectedMovingItemIndex].itemPosition = e.Location;
                        DrawElements();
                    }

            }


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            switch (currentDrawType)
            {
                case DrawType.Line:
                    //Saving Last Point
                    //lastClickedPoint.X = e.X;
                    //lastClickedPoint.Y = e.Y;


                    //Save the Points of the lines in a list to draw them every time
                    //lineList.Add(firstClickedPoint);
                    //lineList.Add(lastClickedPoint);
                    break;
                case DrawType.Rectangle:
                    //Saving Last Point
                    //lastClickedPoint.X = e.X;
                    //lastClickedPoint.Y = e.Y;

                    //Save Points for drawing Rectangles
                    //rectangleList.Add(firstClickedPoint);
                    //rectangleList.Add(lastClickedPoint);
                    break;
                case DrawType.Item:
                    break;
                case DrawType.Select:
                    if (e.Button == MouseButtons.Left)
                        selectedMovingItemIndex = -1;
                    break;
                case DrawType.None:
                    break;
                default:
                    break;
            }
            ////Drawing Line
            //if (currentDrawType == DrawType.Line)
            //{
            //    //Saving Last Point
            //    lastClickedPoint.X = e.X;
            //    lastClickedPoint.Y = e.Y;


            //    //Save the Points of the lines in a list to draw them every time
            //    lineList.Add(firstClickedPoint);
            //    lineList.Add(lastClickedPoint);

            //}

            ////Drawing Rectangle
            //if (currentDrawType == DrawType.Rectangle)
            //{

            //    //Saving Last Point
            //    lastClickedPoint.X = e.X;
            //    lastClickedPoint.Y = e.Y;

            //    //Save Points for drawing Rectangles
            //    rectangleList.Add(firstClickedPoint);
            //    rectangleList.Add(lastClickedPoint);

            //}
            drawStarted = false;  //drawing finished
            //selectedItemindex = -1;
            //g.DrawImage(

        }

        private void toolStripButton_Rectangle_Click(object sender, EventArgs e)
        {
            currentDrawType = DrawType.Rectangle;
            pictureBox1.Cursor = c;
            toolStripButton_DrawLine.Checked = false;
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            DrawElements();
        }
        Cursor c;
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count != 0)
            {
                Bitmap b = new Bitmap(imageList1.Images[listView1.SelectedItems[0].ImageIndex]);
                this.Cursor = CreateCursor(b, 3, 3);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = c;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            DrawElements();
        }

        private void MainForm_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            DrawElements();
        }

        private void MainForm_MaximumSizeChanged(object sender, EventArgs e)
        {
            DrawElements();
        }

        private void MainForm_MinimumSizeChanged(object sender, EventArgs e)
        {
            DrawElements();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            currentDrawType = DrawType.Select;
            pictureBox1.Cursor = this.Cursor;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged(sender, e);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // openFileDialog_OpenProject.ShowDialog();
            if (openFileDialog_OpenProject.ShowDialog() == DialogResult.OK)
                OpenData();
        }

        private void OpenData()
        {
            FileStream fs = new FileStream(openFileDialog_OpenProject.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            //br.ReadInt32();
            Point p = new Point();
            int countOfLine = br.ReadInt32();
            for (int i = 0; i < countOfLine; i++)
            {
                p.X = br.ReadInt32();
                p.Y = br.ReadInt32();

                lineList.Add(p);
            }
            int countOfRectangles = br.ReadInt32();
            for (int i = 0; i < countOfRectangles; i++)
            {
                p.X = br.ReadInt32();
                p.Y = br.ReadInt32();
                rectangleList.Add(p);
            }

            int countOfHouseObjects = br.ReadInt32();
            for (int i = 0; i < countOfHouseObjects; i++)
            {
                p.X = br.ReadInt32();
                p.Y = br.ReadInt32();
                HouseObject houseObject = new HouseObject(p, br.ReadInt32());

                houseObjectsList.Add(houseObject);
            }
            br.Close();
            DrawElements();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_SaveProject.FileName != "")
                SaveData();
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog_SaveProject.ShowDialog();
            if (saveFileDialog_SaveProject.ShowDialog() == DialogResult.OK)
            {
                SaveData();
            }

        }

        private void SaveData()
        {
            FileStream fs = new FileStream(saveFileDialog_SaveProject.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(lineList.Count);
            for (int i = 0; i < lineList.Count; i++)
            {
                bw.Write(lineList[i].X);
                bw.Write(lineList[i].Y);

            }
            bw.Write(rectangleList.Count);
            for (int i = 0; i < rectangleList.Count; i++)
            {
                bw.Write(rectangleList[i].X);
                bw.Write(rectangleList[i].Y);
            }
            bw.Write(houseObjectsList.Count);
            for (int i = 0; i < houseObjectsList.Count; i++)
            {
                bw.Write(houseObjectsList[i].itemPosition.X);
                bw.Write(houseObjectsList[i].itemPosition.Y);
                bw.Write(houseObjectsList[i].itemIndex);
                //bw.Write(houseObjectsList[i].houseObjectName);

            }
            fs.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        List<Control> sensorControls = new List<Control>();

        private void setStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Status Set_Status_Form = new Set_Status();
            HouseObject currentObject = houseObjectsList[selectedItemindex];
            sensorControls = new List<Control>();
            Set_Status_Form.btn_Apply.Click += new EventHandler(btn_Apply_Click);

            for (int i = 0; i < currentObject.sensors.Count; i++)
            {

                Sensor currentSensor = currentObject.sensors[i];
                if (currentSensor.dataFormat == Sensor.SensorDataFormat.Numeral)
                {
                    TextBox txtb_Numeral = new TextBox();
                    txtb_Numeral.Location = new Point(60, i * 30 + 50);
                    Set_Status_Form.Controls.Add(txtb_Numeral);

                    sensorControls.Add(txtb_Numeral);
                }
                else if (currentSensor.dataFormat == Sensor.SensorDataFormat.MultiState)
                {
                    ComboBox cmb_MultiState = new ComboBox();

                    cmb_MultiState.Location = new Point(60, i * 30 + 50);
                    foreach (string s in currentSensor.MultiStateLables)
                    {
                        cmb_MultiState.Items.Add(s);
                    }
                    if (currentSensor.MultiStateLables.Length > 0)
                    {
                        cmb_MultiState.Text = currentSensor.MultiStateLables[0];
                    }

                    Set_Status_Form.Controls.Add(cmb_MultiState);
                    sensorControls.Add(cmb_MultiState);
                }
                else if (currentSensor.dataFormat == Sensor.SensorDataFormat.Point)
                {
                    Label lbl_x = new Label();
                    lbl_x.Text = "X:";

                    Label lbl_y = new Label();
                    lbl_y.Text = "Y:";

                    TextBox txtb_x = new TextBox();
                    TextBox txtb_y = new TextBox();

                    lbl_x.Location = new Point(60, i * 30 + 50);

                    txtb_x.Location = new Point(75, i * 30 + 50);

                    lbl_y.Location = new Point(180, i * 30 + 50);
                    txtb_y.Location = new Point(195, i * 30 + 50);
                    Set_Status_Form.Controls.Add(txtb_x);
                    sensorControls.Add(txtb_x);
                    Set_Status_Form.Controls.Add(txtb_y);
                    sensorControls.Add(txtb_y);
                    Set_Status_Form.Controls.Add(lbl_x);
                    //sensorControls.Add(lbl_x);
                    Set_Status_Form.Controls.Add(lbl_y);
                    //sensorControls.Add(lbl_y);


                }

                Label lbl_SensorName = new Label();
                lbl_SensorName.Text = currentSensor.name + ":";
                lbl_SensorName.Location = new Point(0, i * 30 + 50);
                Set_Status_Form.Controls.Add(lbl_SensorName);

            }



            Set_Status_Form.Text = "Set Status";
            Label SensorName = new Label();
            SensorName.Text = "Hello";
            Set_Status_Form.Controls.Add(SensorName);
            //Set_Status_Form.Load += new EventHandler(Set_Status_Form_Load);


            Set_Status_Form.Show();
        }

        void btn_Apply_Click(object sender, EventArgs e)
        {
            HouseObject currentObject = houseObjectsList[selectedItemindex];
            for (int i = 0, j = 0; i < currentObject.sensors.Count; i++, j++)
            {
                Sensor currentSensor = currentObject.sensors[i];
                if (currentSensor.dataFormat == Sensor.SensorDataFormat.Numeral)
                {
                    currentObject.sensors[i].SetState(float.Parse(sensorControls[j].Text));

                }
                else if (currentSensor.dataFormat == Sensor.SensorDataFormat.MultiState)
                {
                    currentObject.sensors[i].SetState(sensorControls[j].Text);
                }
                else if (currentSensor.dataFormat == Sensor.SensorDataFormat.Point)
                {

                    currentObject.sensors[i].SetState(new Point(int.Parse(sensorControls[j].Text), int.Parse(sensorControls[++j].Text)));

                }
            }
        }

        void Set_Status_Form_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void getStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String status = "";
            HouseObject currentObject = houseObjectsList[selectedItemindex];

            for (int i = 0; i < currentObject.sensors.Count; i++)
            {
                Sensor currentSensor = currentObject.sensors[i];
                status += currentSensor.GetStatus() + "\n";
            }
            MessageBox.Show(status);
        }

        Add_Sensor ads = new Add_Sensor();
        public static List<Sensor> AddedSensors = new List<Sensor>();
        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ads = new Add_Sensor();
            (ads).ShowDialog();
            RefreshListView();

        }

        private void RefreshListView()
        {
            // listView1.Clear();
            //listView1.Items.Add(new ListViewItem(
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void ShowHouseObjectsIcon()
        {
            listView1.Clear();
            for (int i = 0; i < AddedHouseObjects.Count; i++)
            {
                //if (listView1.Items.Contains(new ListViewItem("", AddedHouseObjects[i].itemIndex)))
                //    continue;

                listView1.Items.Add(new ListViewItem("", AddedHouseObjects[i].itemIndex));
                //listView1.Items.RemoveAt(AddedHouseObjects[i].itemIndex);

            }
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHouseObjectsIcon();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void manageSensorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ads = new Add_Sensor();
            (ads).ShowDialog();
            RefreshListView();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowHouseObjectsIcon();
            pictureBox1.Refresh();

        }

        private void addObjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form add = new AddObject(this);//ads);
            add.Show();
        }

       public static Schedule_a_Task SetTask = new Schedule_a_Task();
        private void scheduleATaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTask = new Schedule_a_Task();
            SetTask.Show();
        }
        public static event EventHandler ScheduleItemSelected;
        private void scheduleATaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scheduleATaskToolStripMenuItem_Click(sender, e);
            ScheduleItemSelected(selectedItemindex, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddedSensors.Add(new Sensor("Power", Sensor.SensorDataFormat.MultiState, new string[] { "On", "Off" }));
            AddedSensors.Add(new Sensor("Temperature", Sensor.SensorDataFormat.Numeral));
            AddedSensors.Add(new Sensor("Location", Sensor.SensorDataFormat.Point));
            //------------------------------------Simulating time----------------------------------
            //if (chbox_SimulatedTime.Checked == true)
            //    useRealTime = false;
            //else
            //    useRealTime = true;
            if (LoadDefaultSensors)
            {
                List<Sensor> sensors = new List<Sensor>();
                sensors.Add(new Sensor(AddedSensors[0]));
                sensors.Add(new Sensor(AddedSensors[2]));
                AddedHouseObjects.Add(new HouseObject("Lamp", sensors, imageList1.Images[6], new Point(), 6));

                sensors = new List<Sensor>();
                sensors.Add(new Sensor(AddedSensors[1]));
                sensors.Add(new Sensor(AddedSensors[2]));
                AddedHouseObjects.Add(new HouseObject("Heater", sensors, imageList1.Images[12], new Point(), 12));

                sensors = new List<Sensor>();
                sensors.Add(new Sensor(AddedSensors[2]));
                AddedHouseObjects.Add(new HouseObject("Camera", sensors, imageList1.Images[11], new Point(), 11));
            }
            ShowHouseObjectsIcon();

        }
        Image HousePlan = new Bitmap(5, 5);

        private void chooseHouseBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog_ChooseHouseBackground.ShowDialog() == DialogResult.OK)
                HousePlan = Image.FromFile(openFileDialog_ChooseHouseBackground.FileName);
            DrawElements();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_setSchedule_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
                if (ScheduleTasks[i].Enable)
                if (TimeIsCorrect(ScheduleTasks[i]))
                {
                    RunSchedule(ScheduleTasks[i]);
                    ScheduleTasks[i].Enable = false;
                    SetTask.LoadSchedulesToCheckedList();
                }
            lbl_Status.Text = "House Objects Status:" + HouseObjectsStatus();
        }

        private string HouseObjectsStatus()
        {
            string houseObjectStatus="";
            for (int i = 0; i < houseObjectsList.Count; i++)
            {
                for (int j = 0; j < houseObjectsList[i].sensors.Count; j++)
                {
                    houseObjectStatus += houseObjectsList[i].houseObjectName + ":" + houseObjectsList[i].sensors[j].name+ houseObjectsList[i].sensors[j].GetStatus()+"\n";  
                }
                
            }
            return houseObjectStatus;
        }

        public static void RunSchedule(Schedule schedule)
        {
                MainForm.houseObjectsList[schedule.objectID].sensors[schedule.sensorID].SensorData = schedule.sensorValue;
        }

        private bool TimeIsCorrect(Schedule schedule)
        {
            if (useRealTime)
                simulatedTime = DateTime.Now;
            if (CheckIfItIsToday(schedule.date))
                if (CheckIfTimeIsNowOrPassed(schedule.time))
                    return true;
            return false;
        }

        private bool CheckIfTimeIsNowOrPassed(DateTime dateTime)
        {
            if (useRealTime)
                simulatedTime = DateTime.Now;

            //MessageBox.Show("Time: " + DateTime.Now.TimeOfDay.ToString() + " Now:" + dateTime.TimeOfDay.ToString());
            if (simulatedTime.TimeOfDay.CompareTo(dateTime.TimeOfDay) >= 0)
                return true;
            return false;
        }

        private bool CheckIfItIsToday(DateTime dateTime)
        {
            //MessageBox.Show("Today: " + DateTime.Today.ToString() +" Now:"+ dateTime.Date.ToString());
            //It works. "Today" makes it's time 12AM and so it is convertable!
            if (useRealTime)
                simulatedTime = DateTime.Now;

            if (DateTime.Today.CompareTo(simulatedTime.Date) == 0)
                return true;
            return false;
        }
        Define_Scenario SCF;
        private void defineScenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SCF = new Define_Scenario();
            SCF.Show();
        }

        bool updateRequested = false;
        private void timer_Upload_Download_Tick(object sender, EventArgs e)
        {
            if (btn_UploadSensorData.Checked)
            {
                if (updateRequested)
                {
                    if (sensorUpdateQueue.Count > 0)
                    {
                        KeyValuePair<string, string> sensordata = sensorUpdateQueue.Dequeue();
                        webBrowser1.Navigate(serverAddress + "ReqType=SetSensor&PhysID=" + sensordata.Key +
                    "&Val=" + sensordata.Value);
                    }
                    else
                    {
                        updateRequested = false;
                    }
                }
                else
                {
                    webBrowser1.Navigate(serverAddress+@"ReqType=GetUpdateRequest");
                    //while (webBrowser1.IsBusy)
                    //  ;
                    getUpdateRequest = true;            
                }

                //while (sendData)
                    //;//Wait until the loading is complete
               // foreach (KeyValuePair<string, string> sensordata in sensorUpdateQueue)
               // {
                    //sendData = true;
                 //   webBrowser1.DocumentText = "";
                    //webBrowser1.Navigate(@"http://localhost:1076/MobileServer.aspx" + "?ReqType=SetSensor&PhysID=" + sensordata.Key +
                //"&Val=" + sensordata.Value);
                  //  webBrowser1.Navigate(@"http://localhost:1316/MobileServer.aspx" + "?ReqType=SetSensor&PhysID=" + sensordata.Key +
               // "&Val=" + sensordata.Value);
                   // while (webBrowser1.DocumentText == "")
                        ;//Wait until the loading is complete
                    //MessageBox.Show(@"http://localhost:1076/MobileServer.aspx" + "?ReqType=SetSensor&PhysID=" + sensordata.Key +
                //"&Val=" + sensordata.Value);
               // }
               // sensorUpdateQueue.Clear();
            }
            //else if (btn_DownloadObjectData.Checked)
            //{
            //    while (webBrowser1.IsBusy)
            //        ;//Wait until the loading is complete
            //    webBrowser1.Navigate(@"http://localhost:1076/MobileServer.aspx" + "?ReqType=SetSensor&PhysID=" + sensordata.Key +
            //"&Val=" + sensordata.Value);
            //}
        }
        bool loadobject = false;
        bool getUpdateRequest = false;
        //bool sendData = false;
        private void btn_DownloadObjectData_Click(object sender, EventArgs e)
        {
           // webBrowser1.Navigate(@"http://localhost:1076/MobileServer.aspx?ReqType=GetObjects");
            webBrowser1.Navigate(serverAddress+@"ReqType=GetObjects");
            //while (webBrowser1.IsBusy)
              //  ;
            loadobject = true;            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (loadobject)
            {
                string objectData = webBrowser1.DocumentText;
                string[] lines = objectData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                MessageBox.Show(lines.Length.ToString());
                for (int i = 0; i < lines.Length / 4; i++)
                {
                    string name = lines[4 * i + 0];
                    List<Sensor> sens = new List<Sensor>();// (AddedHouseObjects[listView1.SelectedIndices[0]].sensors);
                    //foreach (Sensor s in AddedHouseObjects[listView1.SelectedIndices[0]].sensors)
                    //{
                    //    s.name = name + "_" + s.name;//Add the object name's prefix to each sensorname
                    //    sensors.Add(new Sensor(s));
                    //}

                    houseObjectsList.Add(new HouseObject(new Point(int.Parse(lines[4 * i + 2]), int.Parse(lines[4 * i + 3])),
                        name,
                        sens, int.Parse(lines[4 * i + 1])));

                }

                DrawElements();
                loadobject = false;
            }
            else if (getUpdateRequest)
            {
                string data = webBrowser1.DocumentText;
                updateRequested = bool.Parse(data);                
                getUpdateRequest = false;
            }
            //sendData = false;
        }


        //--------------------------------------------- Scenario--------------------------------------------------
        public static List<Scenario> listofScenarios = new List<Scenario>();
        public static List<ScheduelesSequence> listOfScheSeq = new List<ScheduelesSequence>();

        public void timer_Scenario_Tick(object sender, EventArgs e)
        {            
            for (int i = 0; i < listofScenarios.Count; i++)
                //if (ScheduleTasks[i].Enable)
                    if (ScenarioTimeIsCorrect(listofScenarios[i]))
                    {
                        if (ScenarioConditionIsCorrect(listofScenarios[i]))
                        {
                            // RunSchedule(ScheduleTasks[i]);
                            RunScenario(listofScenarios[i]);
                            listofScenarios[i].scenarioTime = listofScenarios[i].scenarioTime.AddSeconds(listofScenarios[i].scenarioRepeatTime);
                            //scenario.time=schenario.time.add(scenario.repeattime)
                        }
                       // ScheduleTasks[i].Enable = false;
                        //SetTask.LoadSchedulesToCheckedList();
                    }
        }

        private bool ScenarioConditionIsCorrect(Scenario scenario)
        {
            for (int i = 0; i < scenario.scenarioConditions.Count; i++)
			           {
                          // for (int j = 0; j < MainForm.houseObjectsList.Count; j++)
			             // {   
                                if(MainForm.houseObjectsList[scenario.scenarioConditions[i].conditionObjectID].sensors[scenario.scenarioConditions[i].conditionSensorID].SensorData!=scenario.scenarioConditions[i].conditionSensorValue)
           
                                return false;

                                //else

                                //    return false;
                         // }
                
			       }
            return true;
          
        }

        private void RunScenario(Scenario scenario)
        {
            for (int i = 0; i < scenario.scheduelesSet.Count; i++)
            {
               //scenario.scheduelesSet[i].schedueleItem.time=scenario.scenarioTime.Add(new TimeSpan(scenario.scheduelesSet[i].daysDelayFromFirstScheduele,scenario.scheduelesSet[i].hoursDelayFromFirstScheduele,scenario.scheduelesSet[i].MinutesDelayFromFirstScheduele,scenario.scheduelesSet[i].secondsDelayFromFirstScheduele));
               scenario.scheduelesSet[i].schedueleItem.Enable = true;
              // scenario.scheduelesSet[i].schedueleItem.date = scenario.scenarioDate;
                //scenario.scheduelesSet[i].schedueleItem.o
               RunSchedule(scenario.scheduelesSet[i].schedueleItem);
 
            }
        }

        private bool ScenarioTimeIsCorrect(Scenario scenario)
        {
            if (useRealTime)
                simulatedTime = DateTime.Now;            
            if (CheckIfItIsToday((scenario.scenarioDate)))// ScenarioCheckIfItIsToday
                if (CheckIfTimeIsNowOrPassed((scenario.scenarioTime)))// ScenarioCheckIfTimeIsNowOrPassed
                    return true;
            return false;
        }

        //private bool ScenarioCheckIfTimeIsNowOrPassed(DateTime dateTime)
        //{
        //        if (DateTime.Now.TimeOfDay.CompareTo(dateTime.TimeOfDay) >= 0)
        //        return true;
        //    return false;
        //}

        //private bool ScenarioCheckIfItIsToday(DateTime dateTime)
        //{
        //        if (DateTime.Today.CompareTo(dateTime.Date) == 0)
        //        return true;
        //    return false;
        //}
//------------------------------------------Save Simulated Objects----------------------------------------------
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog_SaveAddedObjects.ShowDialog() == DialogResult.OK)
            {
                SaveAddedObjects();

            }

        }

        //public void SaveSensors
        private void SaveAddedObjects()
        {
            FileStream fs = new FileStream(saveFileDialog_SaveAddedObjects.FileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(AddedHouseObjects.Count);
            for (int i = 0; i <AddedHouseObjects.Count; i++)
            {
                bw.Write(AddedHouseObjects[i].houseObjectName);
               bw.Write(AddedHouseObjects[i].itemIndex);
               SaveObjectSensorstoFile(bw, i);

                
            }
            fs.Close();   
        }

        private static void SaveObjectSensorstoFile(BinaryWriter bw, int i)
        {
            
            bw.Write(AddedHouseObjects[i].sensors.Count);
            for (int j = 0; j < AddedHouseObjects[i].sensors.Count; j++)
			{
			    bw.Write(AddedHouseObjects[i].sensors[j].name);
               
                if (AddedHouseObjects[i].sensors[j].dataFormat == Sensor.SensorDataFormat.Numeral)
                {
                    bw.Write(Sensor.SensorDataFormat.Numeral.ToString());
                    
                }
                else if (AddedHouseObjects[i].sensors[j].dataFormat == Sensor.SensorDataFormat.Point)
                {
                    bw.Write(Sensor.SensorDataFormat.Point.ToString());
                }
                else if (AddedHouseObjects[i].sensors[j].dataFormat == Sensor.SensorDataFormat.MultiState)
                {
                    bw.Write(Sensor.SensorDataFormat.MultiState.ToString());
                    bw.Write(AddedHouseObjects[i].sensors[j].MultiStateLables.GetLength(0));
                    for (int q = 0; q < AddedHouseObjects[i].sensors[j].MultiStateLables.GetLength(0); q++)
                    {
                        bw.Write(AddedHouseObjects[i].sensors[j].MultiStateLables[q]);
                    }
                
                }

			}
           
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog_LoadObjects.ShowDialog() == DialogResult.OK)
                LoadObjects();
        }

        private void LoadObjects()
        {
            FileStream fs = new FileStream(openFileDialog_LoadObjects.FileName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

           // HouseObject simulatedObject = new HouseObject(""); //should be in for
            //List<Sensor> sensorsOfObjet = new List<Sensor>(); // should be in for
            int countOfObjects =br.ReadInt32();
            for (int i = 0; i < countOfObjects; i++)
            {
                //--------- Should be new in for to have all of added items. else they would be all one (the last Item)------ 
                HouseObject simulatedObject = new HouseObject("");
                List<Sensor> sensorsOfObjet = new List<Sensor>();

                simulatedObject.houseObjectName = br.ReadString();
                simulatedObject.itemIndex = br.ReadInt32();
               sensorsOfObjet= LoadObjectSensors(br);
               simulatedObject.sensors = sensorsOfObjet;
               AddedHouseObjects.Add(simulatedObject);
  
            }
            fs.Close();
            
           // AddObject.ObjectChanged();
            ShowHouseObjectsIcon();
            
            //          for (int i = 0; i < AddedHouseObjects.Count; i++)
            //{
            //    //if (listView1.Items.Contains(new ListViewItem("", AddedHouseObjects[i].itemIndex)))
            //    //    continue;

            //    listView1.Items.Add(new ListViewItem("", AddedHouseObjects[i].itemIndex));
            //    //listView1.Items.RemoveAt(AddedHouseObjects[i].itemIndex);

            //}

        }

        private List<Sensor> LoadObjectSensors(BinaryReader br)
        {
            List<Sensor> sensors = new List<Sensor>();
            //Sensor s = new Sensor();// should be in for becausein C# we have a refrence to this and all items refer to one place of memory
            int countOfSensors = br.ReadInt32();
            for (int j = 0; j < countOfSensors; j++)
            {
                Sensor s = new Sensor();// not to be the same all added items to the list
                s.name = br.ReadString();
                string sensorformat = br.ReadString();
                if (sensorformat == "Numeral")
                {
                    s.dataFormat = Sensor.SensorDataFormat.Numeral;
                    sensors.Add(s);
                   // return sensors;
                }
                else if (sensorformat == "Point")
                {
                    s.dataFormat = Sensor.SensorDataFormat.Point;
                    sensors.Add(s);
                    //return sensors;
                }
                else if (sensorformat == "MultiState")
                {
                    int numberOfStates = br.ReadInt32();
                    string[] states = new String[numberOfStates];
                    for (int q = 0; q < numberOfStates; q++)
                    {
                        states[q] = br.ReadString();


                    }
                    s.MultiStateLables = states;
                    s.dataFormat = Sensor.SensorDataFormat.MultiState;
                    sensors.Add(s);
                    //return sensors;
                }
                
            }
            return sensors;
        }

        private void LoadObjectSensors(BinaryReader br, int i)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pictureBox1.Refresh();
            //for (int i = 0; i < AddedHouseObjects.Count; i++)
            //{
            //    AddedHouseObjects.RemoveAt(i);
                
            //}
        }

        private void simulateReadOnlySensorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_StartSimulation_Click(object sender, EventArgs e)
        {
            //useRealTime = false;
            //simulatedTime = DateTime.Now;
            timer_SimulateTime.Enabled = true;
        }

        private void btn_PauseSimulation_Click(object sender, EventArgs e)
        {
            timer_SimulateTime.Enabled = false;
        }

        float timeInterval = 1;
        
        private void timer_SimulateTime_Tick(object sender, EventArgs e)
        {
            try
            {
                float temp = float.Parse(txt_TimeRate.Text) * 1000;
                timeInterval = temp;
            }
            catch (Exception)
            {
                                
            }
          simulatedTime=simulatedTime.AddMilliseconds(timeInterval);
        }

        private void timer_showSimulatedTime_Tick(object sender, EventArgs e)
        {
            txt_ShowsimulatedTime.Text = simulatedTime.ToString();
        }

        private void btn_SetTimeNow_Click(object sender, EventArgs e)
        {
            simulatedTime = DateTime.Now;
        }

        private void chbox_SimulatedTime_CheckedChanged(object sender, EventArgs e)
        {
            useRealTime = chbox_SimulatedTime.Checked;
        }

        private void btn_UploadSensorData_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Status_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbl_Status.Text);
        }

        private void btn_SetNewAddress_Click(object sender, EventArgs e)
        {
            serverAddress = txt_ServerAddress.Text;
        }

        //private void timer_setSchedule_Tick(object sender, EventArgs e)
        //{

        //}

        
    } 
    


}
