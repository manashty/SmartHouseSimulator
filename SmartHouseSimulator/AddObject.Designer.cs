namespace SmartHouseSimulator
{
    partial class AddObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObject));
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_ObjectName = new System.Windows.Forms.TextBox();
            this.cmb_AddSensorsObject = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Objects_Sensors = new System.Windows.Forms.ListBox();
            this.btn_AddSensor = new System.Windows.Forms.Button();
            this.btn_AddObject = new System.Windows.Forms.Button();
            this.groupBox_AddSensor = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_RemoveSensor = new System.Windows.Forms.Button();
            this.listView_icon = new System.Windows.Forms.ListView();
            this.HouseObjectIcon = new System.Windows.Forms.Label();
            this.listBox_AddedHouseObjects = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_AddSensor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the Object:";
            // 
            // txtb_ObjectName
            // 
            this.txtb_ObjectName.Location = new System.Drawing.Point(231, 6);
            this.txtb_ObjectName.Multiline = true;
            this.txtb_ObjectName.Name = "txtb_ObjectName";
            this.txtb_ObjectName.Size = new System.Drawing.Size(129, 24);
            this.txtb_ObjectName.TabIndex = 1;
            this.txtb_ObjectName.TextChanged += new System.EventHandler(this.txtb_ObjectName_TextChanged);
            // 
            // cmb_AddSensorsObject
            // 
            this.cmb_AddSensorsObject.FormattingEnabled = true;
            this.cmb_AddSensorsObject.Items.AddRange(new object[] {
            "Tempreture",
            "Time",
            "Light",
            "Movement",
            "Sound"});
            this.cmb_AddSensorsObject.Location = new System.Drawing.Point(60, 25);
            this.cmb_AddSensorsObject.Name = "cmb_AddSensorsObject";
            this.cmb_AddSensorsObject.Size = new System.Drawing.Size(121, 21);
            this.cmb_AddSensorsObject.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensors:";
            // 
            // listBox_Objects_Sensors
            // 
            this.listBox_Objects_Sensors.ForeColor = System.Drawing.Color.Black;
            this.listBox_Objects_Sensors.FormattingEnabled = true;
            this.listBox_Objects_Sensors.Location = new System.Drawing.Point(13, 74);
            this.listBox_Objects_Sensors.Name = "listBox_Objects_Sensors";
            this.listBox_Objects_Sensors.Size = new System.Drawing.Size(172, 199);
            this.listBox_Objects_Sensors.TabIndex = 4;
            // 
            // btn_AddSensor
            // 
            this.btn_AddSensor.Location = new System.Drawing.Point(187, 23);
            this.btn_AddSensor.Name = "btn_AddSensor";
            this.btn_AddSensor.Size = new System.Drawing.Size(105, 23);
            this.btn_AddSensor.TabIndex = 5;
            this.btn_AddSensor.Text = "Add Sensor";
            this.btn_AddSensor.UseVisualStyleBackColor = true;
            this.btn_AddSensor.Click += new System.EventHandler(this.btn_AddSensor_Click);
            // 
            // btn_AddObject
            // 
            this.btn_AddObject.Location = new System.Drawing.Point(552, 347);
            this.btn_AddObject.Name = "btn_AddObject";
            this.btn_AddObject.Size = new System.Drawing.Size(105, 40);
            this.btn_AddObject.TabIndex = 6;
            this.btn_AddObject.Text = "Add House Object";
            this.btn_AddObject.UseVisualStyleBackColor = true;
            this.btn_AddObject.Click += new System.EventHandler(this.btn_AddObject_Click);
            // 
            // groupBox_AddSensor
            // 
            this.groupBox_AddSensor.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_AddSensor.Controls.Add(this.label3);
            this.groupBox_AddSensor.Controls.Add(this.btn_RemoveSensor);
            this.groupBox_AddSensor.Controls.Add(this.label2);
            this.groupBox_AddSensor.Controls.Add(this.cmb_AddSensorsObject);
            this.groupBox_AddSensor.Controls.Add(this.btn_AddSensor);
            this.groupBox_AddSensor.Controls.Add(this.listBox_Objects_Sensors);
            this.groupBox_AddSensor.Location = new System.Drawing.Point(117, 36);
            this.groupBox_AddSensor.Name = "groupBox_AddSensor";
            this.groupBox_AddSensor.Size = new System.Drawing.Size(303, 342);
            this.groupBox_AddSensor.TabIndex = 7;
            this.groupBox_AddSensor.TabStop = false;
            this.groupBox_AddSensor.Text = "Add Object\'s Sensors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Object\'s Sensors:";
            // 
            // btn_RemoveSensor
            // 
            this.btn_RemoveSensor.Location = new System.Drawing.Point(187, 58);
            this.btn_RemoveSensor.Name = "btn_RemoveSensor";
            this.btn_RemoveSensor.Size = new System.Drawing.Size(105, 23);
            this.btn_RemoveSensor.TabIndex = 6;
            this.btn_RemoveSensor.Text = "Remove Sensor";
            this.btn_RemoveSensor.UseVisualStyleBackColor = true;
            this.btn_RemoveSensor.Click += new System.EventHandler(this.btn_RemoveSensor_Click);
            // 
            // listView_icon
            // 
            this.listView_icon.Location = new System.Drawing.Point(426, 45);
            this.listView_icon.Name = "listView_icon";
            this.listView_icon.Size = new System.Drawing.Size(118, 333);
            this.listView_icon.TabIndex = 9;
            this.listView_icon.UseCompatibleStateImageBehavior = false;
            this.listView_icon.View = System.Windows.Forms.View.SmallIcon;
            this.listView_icon.SelectedIndexChanged += new System.EventHandler(this.listView_icon_SelectedIndexChanged);
            // 
            // HouseObjectIcon
            // 
            this.HouseObjectIcon.AutoSize = true;
            this.HouseObjectIcon.Location = new System.Drawing.Point(426, 29);
            this.HouseObjectIcon.Name = "HouseObjectIcon";
            this.HouseObjectIcon.Size = new System.Drawing.Size(65, 13);
            this.HouseObjectIcon.TabIndex = 10;
            this.HouseObjectIcon.Text = "Object Icon:";
            // 
            // listBox_AddedHouseObjects
            // 
            this.listBox_AddedHouseObjects.FormattingEnabled = true;
            this.listBox_AddedHouseObjects.Location = new System.Drawing.Point(551, 45);
            this.listBox_AddedHouseObjects.Name = "listBox_AddedHouseObjects";
            this.listBox_AddedHouseObjects.Size = new System.Drawing.Size(106, 277);
            this.listBox_AddedHouseObjects.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "List of Added objects:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AddObject
            // 
            this.AcceptButton = this.btn_AddObject;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 468);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox_AddedHouseObjects);
            this.Controls.Add(this.HouseObjectIcon);
            this.Controls.Add(this.listView_icon);
            this.Controls.Add(this.groupBox_AddSensor);
            this.Controls.Add(this.btn_AddObject);
            this.Controls.Add(this.txtb_ObjectName);
            this.Controls.Add(this.label1);
            this.Name = "AddObject";
            this.Text = "Simulate House Object";
            this.Load += new System.EventHandler(this.AddObject_Load);
            this.groupBox_AddSensor.ResumeLayout(false);
            this.groupBox_AddSensor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_ObjectName;
        private System.Windows.Forms.ComboBox cmb_AddSensorsObject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Objects_Sensors;
        private System.Windows.Forms.Button btn_AddSensor;
        private System.Windows.Forms.Button btn_AddObject;
        private System.Windows.Forms.GroupBox groupBox_AddSensor;
        private System.Windows.Forms.Button btn_RemoveSensor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView_icon;
        private System.Windows.Forms.Label HouseObjectIcon;
        private System.Windows.Forms.ListBox listBox_AddedHouseObjects;
        private System.Windows.Forms.Label label4;
    }
}