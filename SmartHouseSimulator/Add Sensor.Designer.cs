namespace SmartHouseSimulator
{
    partial class Add_Sensor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Sensor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_SensorName = new System.Windows.Forms.TextBox();
            this.cmbBox_SensorDataFormat = new System.Windows.Forms.ComboBox();
            this.openFileDialog1_SensorIcon = new System.Windows.Forms.OpenFileDialog();
            this.btn_AddSensor = new System.Windows.Forms.Button();
            this.txtb_MultiStatesSensor = new System.Windows.Forms.TextBox();
            this.Labale3 = new System.Windows.Forms.Label();
            this.listBox_MultiStates = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddState = new System.Windows.Forms.Button();
            this.btn_RemoveState = new System.Windows.Forms.Button();
            this.groupBox_MultiStateSensors = new System.Windows.Forms.GroupBox();
            this.listBox_AddedSensors = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_MultiStateSensors.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(91, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sensor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(91, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sensor Data Format :";
            // 
            // txtb_SensorName
            // 
            this.txtb_SensorName.Location = new System.Drawing.Point(162, 82);
            this.txtb_SensorName.Name = "txtb_SensorName";
            this.txtb_SensorName.Size = new System.Drawing.Size(154, 20);
            this.txtb_SensorName.TabIndex = 2;
            // 
            // cmbBox_SensorDataFormat
            // 
            this.cmbBox_SensorDataFormat.FormattingEnabled = true;
            this.cmbBox_SensorDataFormat.Location = new System.Drawing.Point(195, 108);
            this.cmbBox_SensorDataFormat.Name = "cmbBox_SensorDataFormat";
            this.cmbBox_SensorDataFormat.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_SensorDataFormat.TabIndex = 3;
            this.cmbBox_SensorDataFormat.SelectedIndexChanged += new System.EventHandler(this.cmbBox_SensorDataFormat_SelectedIndexChanged);
            // 
            // openFileDialog1_SensorIcon
            // 
            this.openFileDialog1_SensorIcon.FileName = "openFileDialog_SensorIcon";
            // 
            // btn_AddSensor
            // 
            this.btn_AddSensor.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_AddSensor.Location = new System.Drawing.Point(341, 365);
            this.btn_AddSensor.Name = "btn_AddSensor";
            this.btn_AddSensor.Size = new System.Drawing.Size(130, 40);
            this.btn_AddSensor.TabIndex = 6;
            this.btn_AddSensor.Text = "Add Sensor";
            this.btn_AddSensor.UseVisualStyleBackColor = false;
            this.btn_AddSensor.Click += new System.EventHandler(this.btn_AddSensor_Click);
            // 
            // txtb_MultiStatesSensor
            // 
            this.txtb_MultiStatesSensor.Location = new System.Drawing.Point(104, 16);
            this.txtb_MultiStatesSensor.Multiline = true;
            this.txtb_MultiStatesSensor.Name = "txtb_MultiStatesSensor";
            this.txtb_MultiStatesSensor.Size = new System.Drawing.Size(121, 20);
            this.txtb_MultiStatesSensor.TabIndex = 7;
            // 
            // Labale3
            // 
            this.Labale3.AutoSize = true;
            this.Labale3.Location = new System.Drawing.Point(5, 16);
            this.Labale3.Name = "Labale3";
            this.Labale3.Size = new System.Drawing.Size(102, 13);
            this.Labale3.TabIndex = 8;
            this.Labale3.Text = "Insert State\'s Name:";
            // 
            // listBox_MultiStates
            // 
            this.listBox_MultiStates.FormattingEnabled = true;
            this.listBox_MultiStates.Location = new System.Drawing.Point(8, 57);
            this.listBox_MultiStates.Name = "listBox_MultiStates";
            this.listBox_MultiStates.Size = new System.Drawing.Size(104, 173);
            this.listBox_MultiStates.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sensor Multi States:";
            // 
            // btn_AddState
            // 
            this.btn_AddState.Location = new System.Drawing.Point(129, 57);
            this.btn_AddState.Name = "btn_AddState";
            this.btn_AddState.Size = new System.Drawing.Size(96, 24);
            this.btn_AddState.TabIndex = 11;
            this.btn_AddState.Text = "Add State";
            this.btn_AddState.UseVisualStyleBackColor = true;
            this.btn_AddState.Click += new System.EventHandler(this.btn_AddState_Click);
            // 
            // btn_RemoveState
            // 
            this.btn_RemoveState.Location = new System.Drawing.Point(129, 87);
            this.btn_RemoveState.Name = "btn_RemoveState";
            this.btn_RemoveState.Size = new System.Drawing.Size(96, 23);
            this.btn_RemoveState.TabIndex = 12;
            this.btn_RemoveState.Text = "Remove State";
            this.btn_RemoveState.UseVisualStyleBackColor = true;
            this.btn_RemoveState.Click += new System.EventHandler(this.btn_RemoveState_Click);
            // 
            // groupBox_MultiStateSensors
            // 
            this.groupBox_MultiStateSensors.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_MultiStateSensors.Controls.Add(this.btn_AddState);
            this.groupBox_MultiStateSensors.Controls.Add(this.listBox_MultiStates);
            this.groupBox_MultiStateSensors.Controls.Add(this.label3);
            this.groupBox_MultiStateSensors.Controls.Add(this.btn_RemoveState);
            this.groupBox_MultiStateSensors.Controls.Add(this.txtb_MultiStatesSensor);
            this.groupBox_MultiStateSensors.Controls.Add(this.Labale3);
            this.groupBox_MultiStateSensors.Location = new System.Drawing.Point(94, 146);
            this.groupBox_MultiStateSensors.Name = "groupBox_MultiStateSensors";
            this.groupBox_MultiStateSensors.Size = new System.Drawing.Size(231, 238);
            this.groupBox_MultiStateSensors.TabIndex = 13;
            this.groupBox_MultiStateSensors.TabStop = false;
            this.groupBox_MultiStateSensors.Text = "Multi State Sensor";
            // 
            // listBox_AddedSensors
            // 
            this.listBox_AddedSensors.FormattingEnabled = true;
            this.listBox_AddedSensors.Location = new System.Drawing.Point(341, 95);
            this.listBox_AddedSensors.Name = "listBox_AddedSensors";
            this.listBox_AddedSensors.Size = new System.Drawing.Size(120, 264);
            this.listBox_AddedSensors.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(338, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Added Sensors:";
            // 
            // Add_Sensor
            // 
            this.AcceptButton = this.btn_AddSensor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_AddedSensors);
            this.Controls.Add(this.groupBox_MultiStateSensors);
            this.Controls.Add(this.btn_AddSensor);
            this.Controls.Add(this.cmbBox_SensorDataFormat);
            this.Controls.Add(this.txtb_SensorName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Sensor";
            this.Text = "Simulate Controllable Sensor (Actuator)";
            this.Load += new System.EventHandler(this.Add_Sensor_Load);
            this.groupBox_MultiStateSensors.ResumeLayout(false);
            this.groupBox_MultiStateSensors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_SensorName;
        private System.Windows.Forms.ComboBox cmbBox_SensorDataFormat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1_SensorIcon;
        private System.Windows.Forms.Button btn_AddSensor;
        private System.Windows.Forms.TextBox txtb_MultiStatesSensor;
        private System.Windows.Forms.Label Labale3;
        private System.Windows.Forms.ListBox listBox_MultiStates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddState;
        private System.Windows.Forms.Button btn_RemoveState;
        private System.Windows.Forms.GroupBox groupBox_MultiStateSensors;
        private System.Windows.Forms.ListBox listBox_AddedSensors;
        private System.Windows.Forms.Label label4;
    }
}