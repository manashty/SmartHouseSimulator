using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartHouseSimulator
{
    public partial class Define_Scenario : Form
    {
        public Define_Scenario()
        {
            InitializeComponent();
        }
        Scenario scenario = new Scenario();
        ScheduelesSequence schSeq = new ScheduelesSequence();
        //List<ScheduelesSequence> listOfScheSeq = new List<ScheduelesSequence>();
        private void btn_AddSchedueltoScenario_Click(object sender, EventArgs e)
        {

            //try
            //{
                
           // for (int i = 0; i <checkedListBox_Scheduels.CheckedItems.Count; i++)
           // {
                if (checkedListBox_Scheduels.SelectedItems.Count == 0)
                    MessageBox.Show("Select a Scedueled Task First", "Alert", MessageBoxButtons.OK);
                else
                {
                    //listBox_ScenarioTasks.Items.Add(checkedListBox_Scheduels.SelectedItem);
                    ScheduelesSequence schSeq = CreatScheduelesSequence();
                    listBox_ScenarioTasks.Items.Add(schSeq.schedueleItem.scheduleName);

                }

            //}

            //}
            //catch (Exception ex){
                
            //       MessageBox.Show(ex.ToString());
            //    }
        }
        
        private ScheduelesSequence CreatScheduelesSequence()  // create a list of Schedueles Sequence and set each SchedueleSequence for adding to the List of Tasks in Scenario
        {
           
            //-----------------------------create "schedule Item" for "ScheduelesSequence class" from the selected scheduele----------------------------


            schSeq.schedueleItem.scheduleName = MainForm.ScheduleTasks[checkedListBox_Scheduels.SelectedIndex].scheduleName;
            schSeq.schedueleItem.objectID = MainForm.ScheduleTasks[checkedListBox_Scheduels.SelectedIndex].objectID;
            schSeq.schedueleItem.sensorID = MainForm.ScheduleTasks[checkedListBox_Scheduels.SelectedIndex].sensorID;
            schSeq.schedueleItem.sensorValue = MainForm.ScheduleTasks[checkedListBox_Scheduels.SelectedIndex].sensorValue;
            schSeq.schedueleItem.date = dateTimePicker_ScenarioDate.Value;
            schSeq.schedueleItem.time = dateTimePicker_ScenarioTime.Value.Add(new TimeSpan(int.Parse(txtb_DaysDelayTime.Text), int.Parse(txtb_hoursDelayTime.Text),int.Parse(txtb_minutesDlayTime.Text),int.Parse(txtb_secondsDelayTime.Text)));
            
            
            //-----------------------------create "delay times" for "Schedueles Sequence class" from the text boxes------------------------------------

            schSeq.daysDelayFromFirstScheduele = int.Parse(txtb_DaysDelayTime.Text);
            schSeq.hoursDelayFromFirstScheduele = int.Parse(txtb_hoursDelayTime.Text);
            schSeq.MinutesDelayFromFirstScheduele = int.Parse(txtb_minutesDlayTime.Text);
            schSeq.secondsDelayFromFirstScheduele = int.Parse(txtb_secondsDelayTime.Text);
           MainForm.listOfScheSeq.Add(schSeq);
            return schSeq;
        }

        private void Define_Scenario_Load(object sender, EventArgs e)
        {
            checkedListBox_Scheduels.Items.Clear();
            listBox_ScenarioTasks.Items.Clear();
            checkedListBox_AddedScenarios.Items.Clear();
            for (int i = 0; i < MainForm.ScheduleTasks.Count; i++)
			{
                checkedListBox_Scheduels.Items.Add(MainForm.ScheduleTasks[i].scheduleName);
			}
            for (int i = 0; i <MainForm.listOfScheSeq.Count; i++)
            {
                listBox_ScenarioTasks.Items.Add(MainForm.listOfScheSeq[i].schedueleItem.scheduleName);
            }
            for (int i = 0; i < MainForm.listofScenarios.Count; i++)
            {
                checkedListBox_AddedScenarios.Items.Add(MainForm.listofScenarios[i].scenarioName);
            }

           
        }

        private void btn_AddScenario_Click(object sender, EventArgs e) //create Scenario
        {
            
            scenario.scenarioName = txtb_ScenarioName.Text;
            scenario.scenarioDate = dateTimePicker_ScenarioDate.Value;
            scenario.scenarioTime = dateTimePicker_ScenarioTime.Value;
            scenario.scenarioRepeatTime = (int.Parse(txtb_ScenarioRepeatTime.Text) * 
                (int)(Math.Pow(60,comboBox_ScenarioReapeatTime.SelectedIndex)));
            // create set of Scheduels for executing in defined scenario 
            for (int i = 0; i < listBox_ScenarioTasks.Items.Count; i++)
			{
                scenario.scheduelesSet.Add(MainForm.listOfScheSeq[i]); //Now we have a list of Schedueles Sequence (Scheduel Name + Delay time from the first Scheduel)
			}

            for (int i = 0; i < MainForm.listOfScenarioConditions.Count; i++)
            {
                scenario.scenarioConditions.Add(MainForm.listOfScenarioConditions[i]);
            }

            checkedListBox_AddedScenarios.Items.Add(scenario.scenarioName);

            MainForm.listofScenarios.Add(scenario);
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SetCondition_Click(object sender, EventArgs e)
        {
            Form setCondition = new Set_Scenario_Condition();
            setCondition.Show();
        }

        private void btn_SimulateAllScenariosByRealTime_Click(object sender, EventArgs e)
        {
            
        }
    }
}
