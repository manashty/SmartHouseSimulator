namespace SmartHouseSimulator
{
    partial class Set_Scenario_Condition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.label_NumeralValue = new System.Windows.Forms.Label();
            this.cmb_SelectedObject = new System.Windows.Forms.ComboBox();
            this.label_y = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_PointY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            this.btn_SetCondition = new System.Windows.Forms.Button();
            this.label_x = new System.Windows.Forms.Label();
            this.cmb_SelectSensor = new System.Windows.Forms.ComboBox();
            this.txtb_NumeralValue = new System.Windows.Forms.TextBox();
            this.txtb_PointX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_SetPoint = new System.Windows.Forms.Label();
            this.txtb_ConditionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBox_condition = new System.Windows.Forms.CheckedListBox();
            this.btn_AddConditiontoScenario = new System.Windows.Forms.Button();
            this.btn_Help = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_State);
            this.groupBox1.Controls.Add(this.label_NumeralValue);
            this.groupBox1.Controls.Add(this.cmb_SelectedObject);
            this.groupBox1.Controls.Add(this.label_y);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtb_PointY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_State);
            this.groupBox1.Controls.Add(this.btn_SetCondition);
            this.groupBox1.Controls.Add(this.label_x);
            this.groupBox1.Controls.Add(this.cmb_SelectSensor);
            this.groupBox1.Controls.Add(this.txtb_NumeralValue);
            this.groupBox1.Controls.Add(this.txtb_PointX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_SetPoint);
            this.groupBox1.Controls.Add(this.txtb_ConditionName);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 214);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scenario Condition";
            // 
            // cmb_State
            // 
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(98, 122);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(129, 21);
            this.cmb_State.TabIndex = 16;
            this.cmb_State.Visible = false;
            // 
            // label_NumeralValue
            // 
            this.label_NumeralValue.AutoSize = true;
            this.label_NumeralValue.BackColor = System.Drawing.Color.Transparent;
            this.label_NumeralValue.Location = new System.Drawing.Point(7, 130);
            this.label_NumeralValue.Name = "label_NumeralValue";
            this.label_NumeralValue.Size = new System.Drawing.Size(65, 13);
            this.label_NumeralValue.TabIndex = 4;
            this.label_NumeralValue.Text = "Enter Value:\r\n";
            // 
            // cmb_SelectedObject
            // 
            this.cmb_SelectedObject.FormattingEnabled = true;
            this.cmb_SelectedObject.Location = new System.Drawing.Point(98, 57);
            this.cmb_SelectedObject.Name = "cmb_SelectedObject";
            this.cmb_SelectedObject.Size = new System.Drawing.Size(129, 21);
            this.cmb_SelectedObject.TabIndex = 1;
            this.cmb_SelectedObject.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedObject_SelectedIndexChanged);
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.BackColor = System.Drawing.Color.Transparent;
            this.label_y.Location = new System.Drawing.Point(167, 129);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(17, 13);
            this.label_y.TabIndex = 14;
            this.label_y.Text = "Y:";
            this.label_y.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Object:";
            // 
            // txtb_PointY
            // 
            this.txtb_PointY.Location = new System.Drawing.Point(181, 127);
            this.txtb_PointY.Name = "txtb_PointY";
            this.txtb_PointY.Size = new System.Drawing.Size(63, 20);
            this.txtb_PointY.TabIndex = 13;
            this.txtb_PointY.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Sensor:\r\n";
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Location = new System.Drawing.Point(11, 129);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(68, 13);
            this.label_State.TabIndex = 15;
            this.label_State.Text = "Select State:\r\n";
            this.label_State.Visible = false;
            // 
            // btn_SetCondition
            // 
            this.btn_SetCondition.Location = new System.Drawing.Point(83, 163);
            this.btn_SetCondition.Name = "btn_SetCondition";
            this.btn_SetCondition.Size = new System.Drawing.Size(101, 35);
            this.btn_SetCondition.TabIndex = 19;
            this.btn_SetCondition.Text = "Create Condition";
            this.btn_SetCondition.UseVisualStyleBackColor = true;
            this.btn_SetCondition.Click += new System.EventHandler(this.btn_SetCondition_Click);
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.BackColor = System.Drawing.Color.Transparent;
            this.label_x.Location = new System.Drawing.Point(83, 130);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(17, 13);
            this.label_x.TabIndex = 12;
            this.label_x.Text = "X:";
            this.label_x.Visible = false;
            // 
            // cmb_SelectSensor
            // 
            this.cmb_SelectSensor.FormattingEnabled = true;
            this.cmb_SelectSensor.Location = new System.Drawing.Point(98, 84);
            this.cmb_SelectSensor.Name = "cmb_SelectSensor";
            this.cmb_SelectSensor.Size = new System.Drawing.Size(129, 21);
            this.cmb_SelectSensor.TabIndex = 3;
            this.cmb_SelectSensor.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectSensor_SelectedIndexChanged);
            // 
            // txtb_NumeralValue
            // 
            this.txtb_NumeralValue.Location = new System.Drawing.Point(98, 122);
            this.txtb_NumeralValue.Name = "txtb_NumeralValue";
            this.txtb_NumeralValue.Size = new System.Drawing.Size(129, 20);
            this.txtb_NumeralValue.TabIndex = 5;
            this.txtb_NumeralValue.Visible = false;
            // 
            // txtb_PointX
            // 
            this.txtb_PointX.Location = new System.Drawing.Point(101, 126);
            this.txtb_PointX.Name = "txtb_PointX";
            this.txtb_PointX.Size = new System.Drawing.Size(63, 20);
            this.txtb_PointX.TabIndex = 11;
            this.txtb_PointX.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Condition Name:";
            // 
            // label_SetPoint
            // 
            this.label_SetPoint.AutoSize = true;
            this.label_SetPoint.BackColor = System.Drawing.Color.Transparent;
            this.label_SetPoint.Location = new System.Drawing.Point(11, 129);
            this.label_SetPoint.Name = "label_SetPoint";
            this.label_SetPoint.Size = new System.Drawing.Size(66, 26);
            this.label_SetPoint.TabIndex = 10;
            this.label_SetPoint.Text = "Set Position:\r\n\r\n";
            this.label_SetPoint.Visible = false;
            // 
            // txtb_ConditionName
            // 
            this.txtb_ConditionName.Location = new System.Drawing.Point(98, 31);
            this.txtb_ConditionName.Name = "txtb_ConditionName";
            this.txtb_ConditionName.Size = new System.Drawing.Size(129, 20);
            this.txtb_ConditionName.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(306, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Conditions:";
            // 
            // checkedListBox_condition
            // 
            this.checkedListBox_condition.FormattingEnabled = true;
            this.checkedListBox_condition.Location = new System.Drawing.Point(292, 34);
            this.checkedListBox_condition.Name = "checkedListBox_condition";
            this.checkedListBox_condition.Size = new System.Drawing.Size(121, 199);
            this.checkedListBox_condition.TabIndex = 37;
            this.checkedListBox_condition.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_condition_SelectedIndexChanged);
            // 
            // btn_AddConditiontoScenario
            // 
            this.btn_AddConditiontoScenario.Location = new System.Drawing.Point(292, 260);
            this.btn_AddConditiontoScenario.Name = "btn_AddConditiontoScenario";
            this.btn_AddConditiontoScenario.Size = new System.Drawing.Size(121, 43);
            this.btn_AddConditiontoScenario.TabIndex = 38;
            this.btn_AddConditiontoScenario.Text = "Add Selected Conditions to Scenario";
            this.btn_AddConditiontoScenario.UseVisualStyleBackColor = true;
            this.btn_AddConditiontoScenario.Click += new System.EventHandler(this.btn_AddConditiontoScenario_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(35, 260);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(113, 43);
            this.btn_Help.TabIndex = 39;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // Set_Scenario_Condition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 330);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_AddConditiontoScenario);
            this.Controls.Add(this.checkedListBox_condition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Set_Scenario_Condition";
            this.Text = "Set Scenario Condition";
            this.Load += new System.EventHandler(this.Set_Scenario_Condition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_SelectedObject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SetCondition;
        private System.Windows.Forms.ComboBox cmb_SelectSensor;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label label_NumeralValue;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.TextBox txtb_PointY;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox txtb_NumeralValue;
        private System.Windows.Forms.TextBox txtb_PointX;
        private System.Windows.Forms.Label label_SetPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_ConditionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListBox_condition;
        private System.Windows.Forms.Button btn_AddConditiontoScenario;
        private System.Windows.Forms.Button btn_Help;
    }
}