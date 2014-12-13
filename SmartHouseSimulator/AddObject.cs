using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class AddObject : Form
    {
        //Add_Sensor ads;
        MainForm mf;

        //public delegate void ObjectChange(int numberOfObjects);
        //public static event ObjectChange ObjectChanged;

        public static event EventHandler ObjectChanged;
        public AddObject(MainForm Access_mf)//Add_Sensor ads)
        {
            mf = Access_mf;
            
            InitializeComponent();
            //this.ads = ads;
        }

        private void AddObject_Load(object sender, EventArgs e)
        {
            cmb_AddSensorsObject.DataSource = MainForm.AddedSensors;
            listView_icon.SmallImageList = mf.imageList1;
            listView_icon.LargeImageList = mf.imageList1;
            //listView_icon.Items.Add(imageListIcon.Images as ListViewItem);
            for (int i = 0; i < mf.imageList1.Images.Count; i++)
            {
                listView_icon.Items.Add(new ListViewItem("", i));                
            }
            for (int i = 0; i < MainForm.AddedHouseObjects.Count; i++)
            {
                listBox_AddedHouseObjects.Items.Add(MainForm.AddedHouseObjects[i].houseObjectName);
            }
        }

        private void btn_AddSensor_Click(object sender, EventArgs e)
        {
            try
            {
                listBox_Objects_Sensors.Items.Add(cmb_AddSensorsObject.SelectedItem);
            }
            catch (Exception)
            {

            }
        }

        private void txtb_ObjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_RemoveSensor_Click(object sender, EventArgs e)
        {
            listBox_Objects_Sensors.Items.RemoveAt(listBox_Objects_Sensors.SelectedIndex);
        }

        //List<HouseObject> AddedHouseObjects = new List<HouseObject>();
        private void btn_AddObject_Click(object sender, EventArgs e)
        {
            HouseObject ho=new HouseObject(txtb_ObjectName.Text);
            //ho.houseObjectName =txtb_ObjectName.Text;
            ho.sensors = new List<Sensor>();
            for (int i = 0; i < listBox_Objects_Sensors.Items.Count; i++)
            {
                ho.sensors.Add(listBox_Objects_Sensors.Items[i] as Sensor);
            }
            //ho.HouseObjectIcon = Image.FromFile(fileSelector_HouseObjectIcon.FileName);


            if (listView_icon.SelectedIndices.Count==0)
            {
                MessageBox.Show("Select Object Icon, Please.");
                return;
            }
            else
            {
                ho.itemIndex = listView_icon.SelectedIndices[0];
                ho.HouseObjectIcon = mf.imageList1.Images[listView_icon.SelectedIndices[0]];
            }
            MainForm.AddedHouseObjects.Add(ho);



            listBox_AddedHouseObjects.Items.Add(ho.houseObjectName);
            txtb_ObjectName.Text = "";
            listBox_Objects_Sensors.Items.Clear();
            //MainForm mf = new MainForm();
            //mf.ShowHouseObjectsIcon();
            ObjectChanged(this,null);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView_icon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
