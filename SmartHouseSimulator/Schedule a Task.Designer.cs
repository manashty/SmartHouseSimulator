namespace SmartHouseSimulator
{
    partial class Schedule_a_Task
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_a_Task));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SelectedObject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SelectSensor = new System.Windows.Forms.ComboBox();
            this.label_NumeralValue = new System.Windows.Forms.Label();
            this.txtb_NumeralValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbx_SetTask = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.label_y = new System.Windows.Forms.Label();
            this.txtb_PointY = new System.Windows.Forms.TextBox();
            this.label_State = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.txtb_PointX = new System.Windows.Forms.TextBox();
            this.label_SetPoint = new System.Windows.Forms.Label();
            this.btn_AddScheduel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_ScheduleName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ChangeSchedule = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Help = new System.Windows.Forms.Button();
            this.timer_RunScheduele = new System.Windows.Forms.Timer(this.components);
            this.listBox_ScheduledTasks = new System.Windows.Forms.CheckedListBox();
            this.grbx_SetTask.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // cmb_SelectedObject
            // 
            this.cmb_SelectedObject.FormattingEnabled = true;
            this.cmb_SelectedObject.Location = new System.Drawing.Point(98, 57);
            this.cmb_SelectedObject.Name = "cmb_SelectedObject";
            this.cmb_SelectedObject.Size = new System.Drawing.Size(139, 21);
            this.cmb_SelectedObject.TabIndex = 1;
            this.cmb_SelectedObject.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectedObject_SelectedIndexChanged);
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
            // cmb_SelectSensor
            // 
            this.cmb_SelectSensor.FormattingEnabled = true;
            this.cmb_SelectSensor.Location = new System.Drawing.Point(98, 84);
            this.cmb_SelectSensor.Name = "cmb_SelectSensor";
            this.cmb_SelectSensor.Size = new System.Drawing.Size(139, 21);
            this.cmb_SelectSensor.TabIndex = 3;
            this.cmb_SelectSensor.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectSensor_SelectedIndexChanged);
            // 
            // label_NumeralValue
            // 
            this.label_NumeralValue.AutoSize = true;
            this.label_NumeralValue.BackColor = System.Drawing.Color.Transparent;
            this.label_NumeralValue.Location = new System.Drawing.Point(26, 25);
            this.label_NumeralValue.Name = "label_NumeralValue";
            this.label_NumeralValue.Size = new System.Drawing.Size(65, 13);
            this.label_NumeralValue.TabIndex = 4;
            this.label_NumeralValue.Text = "Enter Value:\r\n";
            // 
            // txtb_NumeralValue
            // 
            this.txtb_NumeralValue.Location = new System.Drawing.Point(101, 22);
            this.txtb_NumeralValue.Name = "txtb_NumeralValue";
            this.txtb_NumeralValue.Size = new System.Drawing.Size(130, 20);
            this.txtb_NumeralValue.TabIndex = 5;
            this.txtb_NumeralValue.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set Date:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(30, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set Time:\r\n";
            // 
            // grbx_SetTask
            // 
            this.grbx_SetTask.BackColor = System.Drawing.Color.Transparent;
            this.grbx_SetTask.Controls.Add(this.dateTimePicker2);
            this.grbx_SetTask.Controls.Add(this.dateTimePicker1);
            this.grbx_SetTask.Controls.Add(this.cmb_State);
            this.grbx_SetTask.Controls.Add(this.label_NumeralValue);
            this.grbx_SetTask.Controls.Add(this.label_y);
            this.grbx_SetTask.Controls.Add(this.txtb_PointY);
            this.grbx_SetTask.Controls.Add(this.label_State);
            this.grbx_SetTask.Controls.Add(this.label5);
            this.grbx_SetTask.Controls.Add(this.label4);
            this.grbx_SetTask.Controls.Add(this.label_x);
            this.grbx_SetTask.Controls.Add(this.txtb_NumeralValue);
            this.grbx_SetTask.Controls.Add(this.txtb_PointX);
            this.grbx_SetTask.Controls.Add(this.label_SetPoint);
            this.grbx_SetTask.Location = new System.Drawing.Point(10, 111);
            this.grbx_SetTask.Name = "grbx_SetTask";
            this.grbx_SetTask.Size = new System.Drawing.Size(276, 170);
            this.grbx_SetTask.TabIndex = 10;
            this.grbx_SetTask.TabStop = false;
            this.grbx_SetTask.Text = "Define Schedule";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 108);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cmb_State
            // 
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(97, 21);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(98, 21);
            this.cmb_State.TabIndex = 16;
            this.cmb_State.Visible = false;
            // 
            // label_y
            // 
            this.label_y.AutoSize = true;
            this.label_y.BackColor = System.Drawing.Color.Transparent;
            this.label_y.Location = new System.Drawing.Point(177, 25);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(17, 13);
            this.label_y.TabIndex = 14;
            this.label_y.Text = "Y:";
            this.label_y.Visible = false;
            // 
            // txtb_PointY
            // 
            this.txtb_PointY.Location = new System.Drawing.Point(198, 24);
            this.txtb_PointY.Name = "txtb_PointY";
            this.txtb_PointY.Size = new System.Drawing.Size(63, 20);
            this.txtb_PointY.TabIndex = 13;
            this.txtb_PointY.Visible = false;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Location = new System.Drawing.Point(30, 24);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(68, 13);
            this.label_State.TabIndex = 15;
            this.label_State.Text = "Select State:\r\n";
            this.label_State.Visible = false;
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.BackColor = System.Drawing.Color.Transparent;
            this.label_x.Location = new System.Drawing.Point(90, 28);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(17, 13);
            this.label_x.TabIndex = 12;
            this.label_x.Text = "X:";
            this.label_x.Visible = false;
            // 
            // txtb_PointX
            // 
            this.txtb_PointX.Location = new System.Drawing.Point(108, 25);
            this.txtb_PointX.Name = "txtb_PointX";
            this.txtb_PointX.Size = new System.Drawing.Size(63, 20);
            this.txtb_PointX.TabIndex = 11;
            this.txtb_PointX.Visible = false;
            // 
            // label_SetPoint
            // 
            this.label_SetPoint.AutoSize = true;
            this.label_SetPoint.BackColor = System.Drawing.Color.Transparent;
            this.label_SetPoint.Location = new System.Drawing.Point(30, 24);
            this.label_SetPoint.Name = "label_SetPoint";
            this.label_SetPoint.Size = new System.Drawing.Size(66, 26);
            this.label_SetPoint.TabIndex = 10;
            this.label_SetPoint.Text = "Set Position:\r\n\r\n";
            this.label_SetPoint.Visible = false;
            // 
            // btn_AddScheduel
            // 
            this.btn_AddScheduel.Location = new System.Drawing.Point(160, 301);
            this.btn_AddScheduel.Name = "btn_AddScheduel";
            this.btn_AddScheduel.Size = new System.Drawing.Size(101, 35);
            this.btn_AddScheduel.TabIndex = 19;
            this.btn_AddScheduel.Text = "Add  Schedule";
            this.btn_AddScheduel.UseVisualStyleBackColor = true;
            this.btn_AddScheduel.Click += new System.EventHandler(this.btn_AddScheduel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Schedule Name:";
            // 
            // txtb_ScheduleName
            // 
            this.txtb_ScheduleName.Location = new System.Drawing.Point(98, 31);
            this.txtb_ScheduleName.Name = "txtb_ScheduleName";
            this.txtb_ScheduleName.Size = new System.Drawing.Size(139, 20);
            this.txtb_ScheduleName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Location = new System.Drawing.Point(-2, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(591, 42);
            this.label7.TabIndex = 27;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.UseCompatibleTextRendering = true;
            this.label7.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_SelectedObject);
            this.groupBox1.Controls.Add(this.btn_Help);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_AddScheduel);
            this.groupBox1.Controls.Add(this.cmb_SelectSensor);
            this.groupBox1.Controls.Add(this.grbx_SetTask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_ScheduleName);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 343);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedueled Task";
            // 
            // btn_ChangeSchedule
            // 
            this.btn_ChangeSchedule.Location = new System.Drawing.Point(42, 301);
            this.btn_ChangeSchedule.Name = "btn_ChangeSchedule";
            this.btn_ChangeSchedule.Size = new System.Drawing.Size(110, 33);
            this.btn_ChangeSchedule.TabIndex = 36;
            this.btn_ChangeSchedule.Text = "Save Changes";
            this.btn_ChangeSchedule.UseVisualStyleBackColor = true;
            this.btn_ChangeSchedule.Click += new System.EventHandler(this.btn_ChangeSchedule_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox_ScheduledTasks);
            this.groupBox2.Controls.Add(this.btn_ChangeSchedule);
            this.groupBox2.Location = new System.Drawing.Point(333, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 343);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run Schedueled Task;";
            // 
            // btn_Help
            // 
            this.btn_Help.Location = new System.Drawing.Point(10, 301);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.Size = new System.Drawing.Size(110, 33);
            this.btn_Help.TabIndex = 43;
            this.btn_Help.Text = "Help";
            this.btn_Help.UseVisualStyleBackColor = true;
            // 
            // timer_RunScheduele
            // 
            this.timer_RunScheduele.Interval = 1500;
            // 
            // listBox_ScheduledTasks
            // 
            this.listBox_ScheduledTasks.FormattingEnabled = true;
            this.listBox_ScheduledTasks.Location = new System.Drawing.Point(16, 31);
            this.listBox_ScheduledTasks.Name = "listBox_ScheduledTasks";
            this.listBox_ScheduledTasks.Size = new System.Drawing.Size(136, 244);
            this.listBox_ScheduledTasks.TabIndex = 46;
            this.listBox_ScheduledTasks.SelectedIndexChanged += new System.EventHandler(this.listBox_ScheduledTasks_SelectedIndexChanged);
            // 
            // Schedule_a_Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(544, 381);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Name = "Schedule_a_Task";
            this.Text = "Define Scenario";
            this.Load += new System.EventHandler(this.Schedule_a_Task_Load);
            this.grbx_SetTask.ResumeLayout(false);
            this.grbx_SetTask.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SelectedObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_SelectSensor;
        private System.Windows.Forms.Label label_NumeralValue;
        private System.Windows.Forms.TextBox txtb_NumeralValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbx_SetTask;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.Label label_State;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.TextBox txtb_PointY;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox txtb_PointX;
        private System.Windows.Forms.Label label_SetPoint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_AddScheduel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_ScheduleName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChangeSchedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Help;
        private System.Windows.Forms.Timer timer_RunScheduele;
        private System.Windows.Forms.CheckedListBox listBox_ScheduledTasks;
    }
}