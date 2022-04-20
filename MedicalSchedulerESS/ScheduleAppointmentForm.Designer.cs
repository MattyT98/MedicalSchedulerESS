
namespace MedicalSchedulerESS
{
    partial class ScheduleAppointmentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clinic_textBox = new System.Windows.Forms.TextBox();
            this.patientName_textBox = new System.Windows.Forms.TextBox();
            this.clinic_label = new System.Windows.Forms.Label();
            this.patientName_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelAppointment_button = new System.Windows.Forms.Button();
            this.bookAppointment_button = new System.Windows.Forms.Button();
            this.viewAppointments_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.availableAppointments_listBox = new System.Windows.Forms.ListBox();
            this.currentAppointment_label = new System.Windows.Forms.Label();
            this.currentAppointment_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.clinic_textBox);
            this.panel1.Controls.Add(this.patientName_textBox);
            this.panel1.Controls.Add(this.clinic_label);
            this.panel1.Controls.Add(this.patientName_label);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 150);
            this.panel1.TabIndex = 0;
            // 
            // clinic_textBox
            // 
            this.clinic_textBox.Location = new System.Drawing.Point(851, 69);
            this.clinic_textBox.Name = "clinic_textBox";
            this.clinic_textBox.ReadOnly = true;
            this.clinic_textBox.Size = new System.Drawing.Size(392, 31);
            this.clinic_textBox.TabIndex = 4;
            // 
            // patientName_textBox
            // 
            this.patientName_textBox.Location = new System.Drawing.Point(237, 69);
            this.patientName_textBox.Name = "patientName_textBox";
            this.patientName_textBox.ReadOnly = true;
            this.patientName_textBox.Size = new System.Drawing.Size(392, 31);
            this.patientName_textBox.TabIndex = 2;
            // 
            // clinic_label
            // 
            this.clinic_label.AutoSize = true;
            this.clinic_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clinic_label.Location = new System.Drawing.Point(851, 16);
            this.clinic_label.Name = "clinic_label";
            this.clinic_label.Size = new System.Drawing.Size(104, 38);
            this.clinic_label.TabIndex = 3;
            this.clinic_label.Text = "Clinic :";
            // 
            // patientName_label
            // 
            this.patientName_label.AutoSize = true;
            this.patientName_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.patientName_label.Location = new System.Drawing.Point(237, 16);
            this.patientName_label.Name = "patientName_label";
            this.patientName_label.Size = new System.Drawing.Size(212, 38);
            this.patientName_label.TabIndex = 2;
            this.patientName_label.Text = "Patient Name :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 115);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 702);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cancelAppointment_button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bookAppointment_button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.viewAppointments_button, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exit_button, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 698);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // cancelAppointment_button
            // 
            this.cancelAppointment_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelAppointment_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelAppointment_button.Location = new System.Drawing.Point(3, 351);
            this.cancelAppointment_button.Name = "cancelAppointment_button";
            this.cancelAppointment_button.Size = new System.Drawing.Size(290, 168);
            this.cancelAppointment_button.TabIndex = 5;
            this.cancelAppointment_button.Text = "Cancel Appointment";
            this.cancelAppointment_button.UseVisualStyleBackColor = true;
            this.cancelAppointment_button.Click += new System.EventHandler(this.cancelAppointment_button_Click);
            // 
            // bookAppointment_button
            // 
            this.bookAppointment_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAppointment_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookAppointment_button.Location = new System.Drawing.Point(3, 177);
            this.bookAppointment_button.Name = "bookAppointment_button";
            this.bookAppointment_button.Size = new System.Drawing.Size(290, 168);
            this.bookAppointment_button.TabIndex = 4;
            this.bookAppointment_button.Text = "Book Appointment";
            this.bookAppointment_button.UseVisualStyleBackColor = true;
            this.bookAppointment_button.Click += new System.EventHandler(this.bookAppointment_button_Click);
            // 
            // viewAppointments_button
            // 
            this.viewAppointments_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAppointments_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewAppointments_button.Location = new System.Drawing.Point(3, 3);
            this.viewAppointments_button.Name = "viewAppointments_button";
            this.viewAppointments_button.Size = new System.Drawing.Size(290, 168);
            this.viewAppointments_button.TabIndex = 3;
            this.viewAppointments_button.Text = "View Available Appointments";
            this.viewAppointments_button.UseVisualStyleBackColor = true;
            this.viewAppointments_button.Click += new System.EventHandler(this.viewAppointments_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(3, 525);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(290, 170);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit Securely";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.currentAppointment_textBox);
            this.panel3.Controls.Add(this.currentAppointment_label);
            this.panel3.Controls.Add(this.availableAppointments_listBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(300, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1021, 702);
            this.panel3.TabIndex = 2;
            // 
            // availableAppointments_listBox
            // 
            this.availableAppointments_listBox.FormattingEnabled = true;
            this.availableAppointments_listBox.ItemHeight = 25;
            this.availableAppointments_listBox.Location = new System.Drawing.Point(17, 14);
            this.availableAppointments_listBox.Name = "availableAppointments_listBox";
            this.availableAppointments_listBox.Size = new System.Drawing.Size(324, 679);
            this.availableAppointments_listBox.TabIndex = 0;
            // 
            // currentAppointment_label
            // 
            this.currentAppointment_label.AutoSize = true;
            this.currentAppointment_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentAppointment_label.Location = new System.Drawing.Point(493, 150);
            this.currentAppointment_label.Name = "currentAppointment_label";
            this.currentAppointment_label.Size = new System.Drawing.Size(360, 45);
            this.currentAppointment_label.TabIndex = 1;
            this.currentAppointment_label.Text = "Current Appointment :";
            // 
            // currentAppointment_textBox
            // 
            this.currentAppointment_textBox.Location = new System.Drawing.Point(493, 253);
            this.currentAppointment_textBox.Name = "currentAppointment_textBox";
            this.currentAppointment_textBox.ReadOnly = true;
            this.currentAppointment_textBox.Size = new System.Drawing.Size(360, 31);
            this.currentAppointment_textBox.TabIndex = 2;
            // 
            // ScheduleAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 852);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ScheduleAppointmentForm";
            this.Text = "ScheduleAppointmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button viewAppointments_button;
        private System.Windows.Forms.Button bookAppointment_button;
        private System.Windows.Forms.Button cancelAppointment_button;
        private System.Windows.Forms.TextBox clinic_textBox;
        private System.Windows.Forms.TextBox patientName_textBox;
        private System.Windows.Forms.Label clinic_label;
        private System.Windows.Forms.Label patientName_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.ListBox availableAppointments_listBox;
        private System.Windows.Forms.Label currentAppointment_label;
        private System.Windows.Forms.TextBox currentAppointment_textBox;
    }
}