using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class Add_Sensor : Form
    {
        public Add_Sensor()
        {
            InitializeComponent();
            //AddObject.ObjectChanged += new AddObject.ObjectChange(AddObject_ObjectChanged);
        }

        void AddObject_ObjectChanged(int numberOfObjects)
        {
            this.Text = "hello";
        }

        private void cmbBox_SensorDataFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBox_SensorDataFormat.SelectedItem.ToString() == Sensor.SensorDataFormat.MultiState.ToString())
            {
                groupBox_MultiStateSensors.Visible = true;
            }
            else
                groupBox_MultiStateSensors.Visible = false;

        }

        private void Add_Sensor_Load(object sender, EventArgs e)
        {
            cmbBox_SensorDataFormat.DataSource = Enum.GetValues((new Sensor.SensorDataFormat()).GetType());
            RefreshSensorsListBox();
        }

        private void btn_BrowsForSemsorIcon_Click(object sender, EventArgs e)
        {
            openFileDialog1_SensorIcon.ShowDialog();
        }

      

        private void btn_AddSensor_Click(object sender, EventArgs e)
        {
            string[] SensorStates =new String[listBox_MultiStates.Items.Count];
            //Preparing multi state labels in the listbox to the sensor state
            if (cmbBox_SensorDataFormat.SelectedItem.ToString() == Sensor.SensorDataFormat.MultiState.ToString() && listBox_MultiStates.Items.Count == 0)
            {
                MessageBox.Show("Insert some States for the Sensor First");
                return;
            }
            for (int i = 0; i < listBox_MultiStates.Items.Count; i++)
			{
                //if (listBox_MultiStates.Items.Count==0)
                //{
                //    SensorStates[i]=txtb_MultiStatesSensor.Text;
                //}
			 SensorStates[i]=listBox_MultiStates.Items[i] as String;
			}
            //Adding NAME of Sensor and
            //MULTI STATE LABELS in the listbox to the sensor state
            if (txtb_SensorName.Text=="")
            {
                MessageBox.Show("Select a name for sensor first");
                return;
            }
            Sensor sensor=new Sensor(txtb_SensorName.Text,((Sensor.SensorDataFormat)cmbBox_SensorDataFormat.SelectedItem),SensorStates );
            MainForm.AddedSensors.Add(sensor);

            txtb_SensorName.Text = "";
            txtb_MultiStatesSensor.Text = "";
            listBox_MultiStates.Items.Clear();

            RefreshSensorsListBox();   
        }

        private void RefreshSensorsListBox()
        {
            listBox_AddedSensors.Items.Clear();
            for (int i = 0; i < MainForm.AddedSensors.Count; i++)
            {
                listBox_AddedSensors.Items.Add(MainForm.AddedSensors[i].name);
            }
        }

        private void btn_AddState_Click(object sender, EventArgs e)
        {
            listBox_MultiStates.Items.Add(txtb_MultiStatesSensor.Text);
            txtb_MultiStatesSensor.Clear();

        }

        private void btn_RemoveState_Click(object sender, EventArgs e)
        {
            listBox_MultiStates.Items.RemoveAt(listBox_MultiStates.SelectedIndex);
        }
    }
}
