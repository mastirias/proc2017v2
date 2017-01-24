namespace Europe_airlines
{
    partial class Form2
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
            this.lb_AirportLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reportStorm = new System.Windows.Forms.Button();
            this.btn_reportConstruction = new System.Windows.Forms.Button();
            this.btn_AddAirplane = new System.Windows.Forms.Button();
            this.btn_removeAirplane = new System.Windows.Forms.Button();
            this.btn_SetDestination = new System.Windows.Forms.Button();
            this.lb_Airplanes = new System.Windows.Forms.ListBox();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.tb_removeAirplanes = new System.Windows.Forms.TextBox();
            this.cBox_desiredDestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAirplanes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_AirportLocation
            // 
            this.lb_AirportLocation.AutoSize = true;
            this.lb_AirportLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AirportLocation.Location = new System.Drawing.Point(12, 9);
            this.lb_AirportLocation.Name = "lb_AirportLocation";
            this.lb_AirportLocation.Size = new System.Drawing.Size(197, 31);
            this.lb_AirportLocation.TabIndex = 0;
            this.lb_AirportLocation.Text = "AirportLocation";
            this.lb_AirportLocation.Click += new System.EventHandler(this.AirportLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add an airplane";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remove an airplane";
            // 
            // btn_reportStorm
            // 
            this.btn_reportStorm.Location = new System.Drawing.Point(12, 63);
            this.btn_reportStorm.Name = "btn_reportStorm";
            this.btn_reportStorm.Size = new System.Drawing.Size(106, 23);
            this.btn_reportStorm.TabIndex = 4;
            this.btn_reportStorm.Text = "Report storm";
            this.btn_reportStorm.UseVisualStyleBackColor = true;
            this.btn_reportStorm.Click += new System.EventHandler(this.btn_reportStorm_Click);
            // 
            // btn_reportConstruction
            // 
            this.btn_reportConstruction.Location = new System.Drawing.Point(124, 63);
            this.btn_reportConstruction.Name = "btn_reportConstruction";
            this.btn_reportConstruction.Size = new System.Drawing.Size(119, 23);
            this.btn_reportConstruction.TabIndex = 5;
            this.btn_reportConstruction.Text = "Report construction";
            this.btn_reportConstruction.UseVisualStyleBackColor = true;
            // 
            // btn_AddAirplane
            // 
            this.btn_AddAirplane.Location = new System.Drawing.Point(511, 102);
            this.btn_AddAirplane.Name = "btn_AddAirplane";
            this.btn_AddAirplane.Size = new System.Drawing.Size(96, 23);
            this.btn_AddAirplane.TabIndex = 6;
            this.btn_AddAirplane.Text = "Add airplane";
            this.btn_AddAirplane.UseVisualStyleBackColor = true;
            this.btn_AddAirplane.Click += new System.EventHandler(this.AddAirplane_Click);
            // 
            // btn_removeAirplane
            // 
            this.btn_removeAirplane.Location = new System.Drawing.Point(511, 246);
            this.btn_removeAirplane.Name = "btn_removeAirplane";
            this.btn_removeAirplane.Size = new System.Drawing.Size(96, 23);
            this.btn_removeAirplane.TabIndex = 7;
            this.btn_removeAirplane.Text = "remove airplane";
            this.btn_removeAirplane.UseVisualStyleBackColor = true;
            this.btn_removeAirplane.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_SetDestination
            // 
            this.btn_SetDestination.Location = new System.Drawing.Point(511, 352);
            this.btn_SetDestination.Name = "btn_SetDestination";
            this.btn_SetDestination.Size = new System.Drawing.Size(96, 23);
            this.btn_SetDestination.TabIndex = 8;
            this.btn_SetDestination.Text = "Set destination";
            this.btn_SetDestination.UseVisualStyleBackColor = true;
            this.btn_SetDestination.Click += new System.EventHandler(this.button5_Click);
            // 
            // lb_Airplanes
            // 
            this.lb_Airplanes.FormattingEnabled = true;
            this.lb_Airplanes.Location = new System.Drawing.Point(12, 138);
            this.lb_Airplanes.Name = "lb_Airplanes";
            this.lb_Airplanes.Size = new System.Drawing.Size(231, 329);
            this.lb_Airplanes.TabIndex = 9;
            this.lb_Airplanes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Location = new System.Drawing.Point(279, 107);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(112, 20);
            this.tb_CompanyName.TabIndex = 11;
            this.tb_CompanyName.Text = "Company Name";
            this.tb_CompanyName.Click += new System.EventHandler(this.tb_CompanyName_Click);
            this.tb_CompanyName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tb_removeAirplanes
            // 
            this.tb_removeAirplanes.Enabled = false;
            this.tb_removeAirplanes.Location = new System.Drawing.Point(280, 249);
            this.tb_removeAirplanes.Name = "tb_removeAirplanes";
            this.tb_removeAirplanes.Size = new System.Drawing.Size(111, 20);
            this.tb_removeAirplanes.TabIndex = 12;
            // 
            // cBox_desiredDestination
            // 
            this.cBox_desiredDestination.FormattingEnabled = true;
            this.cBox_desiredDestination.Location = new System.Drawing.Point(280, 354);
            this.cBox_desiredDestination.Name = "cBox_desiredDestination";
            this.cBox_desiredDestination.Size = new System.Drawing.Size(111, 21);
            this.cBox_desiredDestination.TabIndex = 13;
            this.cBox_desiredDestination.Text = "Choose destination";
            this.cBox_desiredDestination.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cBox_desiredDestination.Click += new System.EventHandler(this.cBox_desiredDestination_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pick the desired destination";
            // 
            // lbAirplanes
            // 
            this.lbAirplanes.AutoSize = true;
            this.lbAirplanes.Location = new System.Drawing.Point(15, 107);
            this.lbAirplanes.Name = "lbAirplanes";
            this.lbAirplanes.Size = new System.Drawing.Size(147, 13);
            this.lbAirplanes.TabIndex = 1;
            this.lbAirplanes.Text = "Airplanes and current airports:";
            this.lbAirplanes.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBox_desiredDestination);
            this.Controls.Add(this.tb_removeAirplanes);
            this.Controls.Add(this.tb_CompanyName);
            this.Controls.Add(this.lb_Airplanes);
            this.Controls.Add(this.btn_SetDestination);
            this.Controls.Add(this.btn_removeAirplane);
            this.Controls.Add(this.btn_AddAirplane);
            this.Controls.Add(this.btn_reportConstruction);
            this.Controls.Add(this.btn_reportStorm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAirplanes);
            this.Controls.Add(this.lb_AirportLocation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing_1);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AirportLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reportStorm;
        private System.Windows.Forms.Button btn_reportConstruction;
        private System.Windows.Forms.Button btn_AddAirplane;
        private System.Windows.Forms.Button btn_removeAirplane;
        private System.Windows.Forms.Button btn_SetDestination;
        private System.Windows.Forms.ListBox lb_Airplanes;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.TextBox tb_removeAirplanes;
        private System.Windows.Forms.ComboBox cBox_desiredDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAirplanes;
    }
}