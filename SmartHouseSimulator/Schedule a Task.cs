using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class Schedule_a_Task : Form
    {

        public Schedule_a_Task()
        {
            InitializeComponent();
            MainForm.ScheduleItemSelected += new EventHandler(MainForm_ScheduleItemSelected);
        }

        void MainForm_ScheduleItemSelected(object sender, EventArgs e)
        {
            LoadObjects();
            cmb_SelectedObject.SelectedIndex = (int)sender;
        }

        private void Schedule_a_Task_Load(object sender, EventArgs e)
        {
            LoadObjects();
            LoadSchedulesToCheckedList();
            
        }

        public void LoadSchedulesToCheckedList()
        {
            listBox_ScheduledTasks.Items.Clear();
            for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
            {

                listBox_ScheduledTasks.Items.Add(MainForm.ScheduleTasks[i].scheduleName);
                listBox_ScheduledTasks.SetSelected(i, MainForm.ScheduleTasks[i].Enable);
            }
        }

        public void LoadObjects()
        {
            cmb_SelectedObject.Items.Clear();
           
            for (int i = 0; i < MainForm.houseObjectsList.Count; i++)
            {
                cmb_SelectedObject.Items.Add(MainForm.houseObjectsList[i].houseObjectName);
            }

        }

        private void cmb_SelectedObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SelectSensor.Items.Clear();
            foreach (Sensor s in MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors)
            {
                cmb_SelectSensor.Items.Add(s.name);
                cmb_SelectSensor.SelectedIndex = 0;
            }
            
            
            //cmb_SelectSensor.Items.Add(MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[i]);
        }

        private void cmb_SelectSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_State.Items.Clear();
            txtb_PointX.Text = "";
            txtb_PointY.Text ="";

            if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
            {
                label_NumeralValue.Visible = true;
                txtb_NumeralValue.Visible = true;


                label_SetPoint.Visible = false;
                label_x.Visible = false;
                label_y.Visible = false;
                txtb_PointX.Visible = false;
                txtb_PointY.Visible = false;
                label_State.Visible = false;
                cmb_State.Visible = false;

            }
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
            {
                label_SetPoint.Visible = true;
                label_x.Visible = true;
                label_y.Visible = true;
                txtb_PointX.Visible = true;
                txtb_PointY.Visible = true;


                label_NumeralValue.Visible = false;
                txtb_NumeralValue.Visible = false;

                label_State.Visible = false;
                cmb_State.Visible = false;

            }
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
            {
                label_State.Visible = true;
                cmb_State.Visible = true;
                foreach (string s in MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].MultiStateLables)
                {
                    cmb_State.Items.Add(s);
                }

                label_NumeralValue.Visible = false;
                txtb_NumeralValue.Visible = false;
                label_SetPoint.Visible = false;
                label_x.Visible = false;
                label_y.Visible = false;
                txtb_PointX.Visible = false;
                txtb_PointY.Visible = false;

            }
            else
            {

                label_NumeralValue.Visible = false;
                txtb_NumeralValue.Visible = false;
                label_SetPoint.Visible = false;
                label_x.Visible = false;
                label_y.Visible = false;
                txtb_PointX.Visible = false;
                txtb_PointY.Visible = false;
                label_State.Visible = false;
                cmb_State.Visible = false;

            }

        }

       // List<Schedule> ScheduleTasks = new List<Schedule>();
        private void btn_AddScheduel_Click(object sender, EventArgs e)
        {
            try
            {
                Schedule scheduleTask = CreateNewSchedule();

                MainForm.ScheduleTasks.Add(scheduleTask);

                LoadSchedulesToCheckedList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please check that sensor values are in correct format.");
            }
        }

        private Schedule CreateNewSchedule()
        {
            Schedule scheduleTask = new Schedule();

            //scheduleTask.objectName = cmb_SelectedObject.Text;
            //scheduleTask.sensorName = cmb_SelectSensor.Text;

            scheduleTask.scheduleName = txtb_ScheduleName.Text;

            scheduleTask.objectID = cmb_SelectedObject.SelectedIndex;
            scheduleTask.sensorID = cmb_SelectSensor.SelectedIndex;

            scheduleTask.date = dateTimePicker1.Value;
            scheduleTask.time = dateTimePicker2.Value;

            if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
                scheduleTask.sensorValue = float.Parse(txtb_NumeralValue.Text);
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
            {
                Point Location = new Point(int.Parse(txtb_PointX.Text), int.Parse(txtb_PointY.Text));
                scheduleTask.sensorValue = Location;
            }
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
                scheduleTask.sensorValue = cmb_State.Text;
            return scheduleTask;
        }

      

        private void listBox_ScheduledTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ScheduledTasks.SelectedIndex != -1)
            {
                MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].Enable = listBox_ScheduledTasks.GetSelected(listBox_ScheduledTasks.SelectedIndex);

                txtb_ScheduleName.Text = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].scheduleName;
                cmb_SelectedObject.SelectedIndex = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].objectID;
                cmb_SelectSensor.SelectedIndex = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorID;


                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
                    txtb_NumeralValue.Text =(MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue).ToString();
                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
                {
                    Point p = new Point();
                    p = (Point)MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue;
                    txtb_PointX.Text = p.X.ToString();
                    txtb_PointY.Text = p.Y.ToString();
                }
                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
                    cmb_State.Text = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue as String;

                dateTimePicker1.Value = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].date;
                dateTimePicker2.Value = MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].time;
            }

        }

        private void listBox_ScheduledTasks_Click(object sender, EventArgs e)
        {
            //listBox_ScheduledTasks_SelectedIndexChanged(sender, e);
        }

        private void btn_ChangeSchedule_Click(object sender, EventArgs e)
        {
            MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].scheduleName=txtb_ScheduleName.Text ;
             MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].objectID=cmb_SelectedObject.SelectedIndex;
             MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorID=cmb_SelectSensor.SelectedIndex;

             if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
                 MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue=txtb_NumeralValue.Text;
             if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
             {
                  Point p = new Point();
                p.X=int.Parse(txtb_PointX.Text);
                p.Y = int.Parse(txtb_PointY.Text);
                
                 MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue=p;
             }
             if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
                   MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].sensorValue=cmb_State.Text;

             MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].date=dateTimePicker1.Value ;
             MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndex].time= dateTimePicker2.Value;
             //listBox_ScheduledTasks.Items.Clear();
             //for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
             //{
             //    listBox_ScheduledTasks.Items.Add(MainForm.ScheduleTasks[i]);
             //}
        }

        //private void btn_SimulatSelectedTask_Click(object sender, EventArgs e)
        //{
        //    int numOfSelectedTask = listBox_ScheduledTasks.SelectedIndices.Count;
        //    for (int i = 0; i < numOfSelectedTask; i++)
        //    {
        //     // if(listBox_ScheduledTasks.SelectedIndex!=-1)
        //        MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndices[i]].Enable = true;

        //        MainForm.RunSchedule(MainForm.ScheduleTasks[listBox_ScheduledTasks.SelectedIndices[i]]);
        //    }
        //}

        //private void btn_SimulatTaskRespectly_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
        //    {
        //        // if(listBox_ScheduledTasks.SelectedIndex!=-1)
        //        MainForm.ScheduleTasks[i].Enable = true;

        //        MainForm.RunSchedule(MainForm.ScheduleTasks[i]);
        //    }
        //}

        //private void btn_SimulatTaskByRealTime_Click(object sender, EventArgs e)
        //{
        //    timer_RunScheduele.Enabled = true;
        //}

        //private void timer_RunScheduele_Tick(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
        //        if (MainForm.ScheduleTasks[i].Enable)
        //            if (TimeIsCorrect(MainForm.ScheduleTasks[i]))
        //            {
        //                MainForm.RunSchedule(MainForm.ScheduleTasks[i]);
        //                MainForm.ScheduleTasks[i].Enable = false;
        //                MainForm.SetTask.LoadSchedulesToCheckedList();
        //            }
        //}
        //private bool TimeIsCorrect(Schedule schedule)
        //{
        //    if (CheckIfItIsToday(schedule.date))
        //        if (CheckIfTimeIsNowOrPassed(schedule.time))
        //            return true;
        //    return false;
        //}

        //private bool CheckIfTimeIsNowOrPassed(DateTime dateTime)
        //{
        //    //MessageBox.Show("Time: " + DateTime.Now.TimeOfDay.ToString() + " Now:" + dateTime.TimeOfDay.ToString());
        //    if (DateTime.Now.TimeOfDay.CompareTo(dateTime.TimeOfDay) >= 0)
        //        return true;
        //    return false;
        //}

        //private bool CheckIfItIsToday(DateTime dateTime)
        //{
        //    //MessageBox.Show("Today: " + DateTime.Today.ToString() +" Now:"+ dateTime.Date.ToString());
        //    //It works. "Today" makes it's time 12AM and so it is convertable!
        //    if (DateTime.Today.CompareTo(dateTime.Date) == 0)
        //        return true;
        //    return false;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
        //    {
        //        MainForm.ScheduleTasks[i].Enable = true;
        //    }
        //    timer_RunScheduele.Enabled = true;
        //}

        //private void timer_RunScheduele_Tick(object sender, EventArgs e)
        //{

        //}

        //private void btn_SimulatTaskByRealTime_Click(object sender, EventArgs e)
        //{

        //}


        //private void btn_DeleteSchedule_Click(object sender, EventArgs e)
        //{

        //}

        
        
    }
}
