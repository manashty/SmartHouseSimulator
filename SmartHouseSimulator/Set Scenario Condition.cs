using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class Set_Scenario_Condition : Form
    {
        //public static List<Condition> listOfConditiones = new List<Condition>();
        public Set_Scenario_Condition()
        {
            InitializeComponent();
        }

        private void Set_Scenario_Condition_Load(object sender, EventArgs e)
        {
            LoadObjectstoConditionForm();

            //----Load Added Conditiones to checkedListBox_Conditions------
            for (int i = 0; i < MainForm.listOfConditiones.Count; i++)
            {
                checkedListBox_condition.Items.Add(MainForm.listOfConditiones[i].conditionName); 
            }
        }

        private void LoadObjectstoConditionForm()
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
        }

        private void cmb_SelectSensor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_State.Items.Clear();
            txtb_PointX.Text = "";
            txtb_PointY.Text = "";

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

        private void btn_SetCondition_Click(object sender, EventArgs e)
        {
            Condition scenarioCondition = new Condition();
            scenarioCondition= CreateCondition();
           MainForm.listOfConditiones.Add(scenarioCondition);
            LoadConditionsToCheckedListBox();
            

        }

        private void LoadConditionsToCheckedListBox()
        {
            
            checkedListBox_condition.Items.Clear();
            for (int i = 0; i < MainForm.listOfConditiones.Count; i++)
            {

                checkedListBox_condition.Items.Add(MainForm.listOfConditiones[i].conditionName);
               
            }
        }

        private Condition CreateCondition()
        {
            //--------------------create condition---------------------
            Condition scenarioCondition = new Condition();
            scenarioCondition.conditionName = txtb_ConditionName.Text;
            scenarioCondition.conditionObjectID = cmb_SelectedObject.SelectedIndex;
            scenarioCondition.conditionSensorID = cmb_SelectSensor.SelectedIndex;

            //---------load proper controles accourding to sensor selected type------------------------

            if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
                scenarioCondition.conditionSensorValue = float.Parse(txtb_NumeralValue.Text);
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
            {
                Point Location = new Point(int.Parse(txtb_PointX.Text), int.Parse(txtb_PointY.Text));
                scenarioCondition.conditionSensorValue = Location;
            }
            else if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
                scenarioCondition.conditionSensorValue = cmb_State.Text;
            return scenarioCondition;
        }

        private void checkedListBox_condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox_condition.SelectedIndex != -1)
            {
                //MainForm.ScheduleTasks[checkedListBox_condition.SelectedIndex].Enable = listBox_ScheduledTasks.GetSelected(listBox_ScheduledTasks.SelectedIndex);

                txtb_ConditionName.Text = MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionName;
                cmb_SelectedObject.SelectedIndex = MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionObjectID;
                cmb_SelectSensor.SelectedIndex = MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionSensorID;


                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Numeral)
                    txtb_NumeralValue.Text = (MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionSensorValue).ToString();
                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.Point)
                {
                    Point p = new Point();
                    p = (Point)MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionSensorValue;
                    txtb_PointX.Text = p.X.ToString();
                    txtb_PointY.Text = p.Y.ToString();
                }
                if (MainForm.houseObjectsList[cmb_SelectedObject.SelectedIndex].sensors[cmb_SelectSensor.SelectedIndex].dataFormat == Sensor.SensorDataFormat.MultiState)
                    cmb_State.Text = MainForm.listOfConditiones[checkedListBox_condition.SelectedIndex].conditionSensorValue as String;
            }

        }

        private void btn_AddConditiontoScenario_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_condition.SelectedIndices.Count; i++)
			{
			 MainForm.listOfScenarioConditions.Add(MainForm.listOfConditiones[checkedListBox_condition.SelectedIndices[i]]);
			}
            
        }
    }
}
