
namespace MedicalSchedulerESS
{
    partial class AppointmentLocateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reference_label = new System.Windows.Forms.Label();
            this.code_label = new System.Windows.Forms.Label();
            this.reference_textBox = new System.Windows.Forms.TextBox();
            this.code_textBox = new System.Windows.Forms.TextBox();
            this.scheduleAppointment_button = new System.Windows.Forms.Button();
            this.dob_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.postcode_textBox = new System.Windows.Forms.TextBox();
            this.postcode_label = new System.Windows.Forms.Label();
            this.dob_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reference_label
            // 
            this.reference_label.AutoSize = true;
            this.reference_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reference_label.Location = new System.Drawing.Point(333, 412);
            this.reference_label.Name = "reference_label";
            this.reference_label.Size = new System.Drawing.Size(176, 45);
            this.reference_label.TabIndex = 0;
            this.reference_label.Text = "Reference:";
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.code_label.Location = new System.Drawing.Point(403, 492);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(106, 45);
            this.code_label.TabIndex = 1;
            this.code_label.Text = "Code:";
            // 
            // reference_textBox
            // 
            this.reference_textBox.Location = new System.Drawing.Point(556, 425);
            this.reference_textBox.Name = "reference_textBox";
            this.reference_textBox.PlaceholderText = "Enter Apppointment Reference";
            this.reference_textBox.Size = new System.Drawing.Size(256, 31);
            this.reference_textBox.TabIndex = 3;
            // 
            // code_textBox
            // 
            this.code_textBox.Location = new System.Drawing.Point(556, 506);
            this.code_textBox.Name = "code_textBox";
            this.code_textBox.PlaceholderText = "Enter Appointment code";
            this.code_textBox.Size = new System.Drawing.Size(256, 31);
            this.code_textBox.TabIndex = 4;
            // 
            // scheduleAppointment_button
            // 
            this.scheduleAppointment_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scheduleAppointment_button.Location = new System.Drawing.Point(454, 797);
            this.scheduleAppointment_button.Name = "scheduleAppointment_button";
            this.scheduleAppointment_button.Size = new System.Drawing.Size(224, 100);
            this.scheduleAppointment_button.TabIndex = 2;
            this.scheduleAppointment_button.Text = "Schedule Appointment";
            this.scheduleAppointment_button.UseVisualStyleBackColor = true;
            this.scheduleAppointment_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dob_dateTimePicker
            // 
            this.dob_dateTimePicker.Location = new System.Drawing.Point(560, 585);
            this.dob_dateTimePicker.Name = "dob_dateTimePicker";
            this.dob_dateTimePicker.Size = new System.Drawing.Size(256, 31);
            this.dob_dateTimePicker.TabIndex = 13;
            this.dob_dateTimePicker.Value = new System.DateTime(1998, 9, 24, 0, 0, 0, 0);
            // 
            // postcode_textBox
            // 
            this.postcode_textBox.Location = new System.Drawing.Point(560, 665);
            this.postcode_textBox.Name = "postcode_textBox";
            this.postcode_textBox.PlaceholderText = "Enter Postcode";
            this.postcode_textBox.Size = new System.Drawing.Size(256, 31);
            this.postcode_textBox.TabIndex = 12;
            // 
            // postcode_label
            // 
            this.postcode_label.AutoSize = true;
            this.postcode_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.postcode_label.Location = new System.Drawing.Point(331, 651);
            this.postcode_label.Name = "postcode_label";
            this.postcode_label.Size = new System.Drawing.Size(166, 45);
            this.postcode_label.TabIndex = 11;
            this.postcode_label.Text = "Postcode:";
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dob_label.Location = new System.Drawing.Point(403, 571);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(94, 45);
            this.dob_label.TabIndex = 10;
            this.dob_label.Text = "DoB:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(454, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 209);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // exit_button
            // 
            this.exit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(997, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(159, 53);
            this.exit_button.TabIndex = 15;
            this.exit_button.Text = "Exit System";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // AppointmentLocateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1168, 1021);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dob_dateTimePicker);
            this.Controls.Add(this.postcode_textBox);
            this.Controls.Add(this.postcode_label);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.code_textBox);
            this.Controls.Add(this.reference_textBox);
            this.Controls.Add(this.scheduleAppointment_button);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.reference_label);
            this.Name = "AppointmentLocateForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reference_label;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox reference_textBox;
        private System.Windows.Forms.TextBox code_textBox;
        private System.Windows.Forms.Button scheduleAppointment_button;
        private System.Windows.Forms.DateTimePicker dob_dateTimePicker;
        private System.Windows.Forms.TextBox postcode_textBox;
        private System.Windows.Forms.Label postcode_label;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exit_button;
    }
}

