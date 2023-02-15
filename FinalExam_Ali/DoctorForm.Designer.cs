namespace FinalExam_Ali
{
    partial class DoctorForm
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
            this.AddDocButton = new System.Windows.Forms.Button();
            this.UpdateDocButton = new System.Windows.Forms.Button();
            this.DeleteDocButton = new System.Windows.Forms.Button();
            this.goToPatientButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoctorIDtextBox = new System.Windows.Forms.TextBox();
            this.DocFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.DocLastNameTextBox = new System.Windows.Forms.TextBox();
            this.DocDepCodeTextBox = new System.Windows.Forms.TextBox();
            this.DocYearPracticTextBox = new System.Windows.Forms.TextBox();
            this.DocShiftHoursTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView_Doctor = new System.Windows.Forms.DataGridView();
            this.DocFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDocButton
            // 
            this.AddDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDocButton.Location = new System.Drawing.Point(649, 33);
            this.AddDocButton.Name = "AddDocButton";
            this.AddDocButton.Size = new System.Drawing.Size(205, 42);
            this.AddDocButton.TabIndex = 0;
            this.AddDocButton.Text = "Add Doctor";
            this.AddDocButton.UseVisualStyleBackColor = true;
            this.AddDocButton.Click += new System.EventHandler(this.AddDocButton_Click);
            // 
            // UpdateDocButton
            // 
            this.UpdateDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDocButton.Location = new System.Drawing.Point(649, 81);
            this.UpdateDocButton.Name = "UpdateDocButton";
            this.UpdateDocButton.Size = new System.Drawing.Size(205, 42);
            this.UpdateDocButton.TabIndex = 1;
            this.UpdateDocButton.Text = "Update";
            this.UpdateDocButton.UseVisualStyleBackColor = true;
            this.UpdateDocButton.Click += new System.EventHandler(this.UpdateDocButton_Click);
            // 
            // DeleteDocButton
            // 
            this.DeleteDocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDocButton.Location = new System.Drawing.Point(649, 136);
            this.DeleteDocButton.Name = "DeleteDocButton";
            this.DeleteDocButton.Size = new System.Drawing.Size(205, 42);
            this.DeleteDocButton.TabIndex = 2;
            this.DeleteDocButton.Text = "Delete";
            this.DeleteDocButton.UseVisualStyleBackColor = true;
            this.DeleteDocButton.Click += new System.EventHandler(this.DeleteDocButton_Click);
            // 
            // goToPatientButton
            // 
            this.goToPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToPatientButton.Location = new System.Drawing.Point(649, 194);
            this.goToPatientButton.Name = "goToPatientButton";
            this.goToPatientButton.Size = new System.Drawing.Size(205, 50);
            this.goToPatientButton.TabIndex = 3;
            this.goToPatientButton.Text = "Go To  Patient";
            this.goToPatientButton.UseVisualStyleBackColor = true;
            this.goToPatientButton.Click += new System.EventHandler(this.goToPatientButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(649, 254);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(205, 50);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "DoctorID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lastname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "DepartmentCode:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Years Of Practice:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 32);
            this.label6.TabIndex = 10;
            this.label6.Text = "Shift Hours:";
            // 
            // DoctorIDtextBox
            // 
            this.DoctorIDtextBox.Location = new System.Drawing.Point(326, 33);
            this.DoctorIDtextBox.Multiline = true;
            this.DoctorIDtextBox.Name = "DoctorIDtextBox";
            this.DoctorIDtextBox.Size = new System.Drawing.Size(275, 32);
            this.DoctorIDtextBox.TabIndex = 11;
            // 
            // DocFirstNameTextBox
            // 
            this.DocFirstNameTextBox.Location = new System.Drawing.Point(326, 85);
            this.DocFirstNameTextBox.Multiline = true;
            this.DocFirstNameTextBox.Name = "DocFirstNameTextBox";
            this.DocFirstNameTextBox.Size = new System.Drawing.Size(275, 32);
            this.DocFirstNameTextBox.TabIndex = 12;
            // 
            // DocLastNameTextBox
            // 
            this.DocLastNameTextBox.Location = new System.Drawing.Point(326, 136);
            this.DocLastNameTextBox.Multiline = true;
            this.DocLastNameTextBox.Name = "DocLastNameTextBox";
            this.DocLastNameTextBox.Size = new System.Drawing.Size(275, 32);
            this.DocLastNameTextBox.TabIndex = 13;
            // 
            // DocDepCodeTextBox
            // 
            this.DocDepCodeTextBox.Location = new System.Drawing.Point(326, 188);
            this.DocDepCodeTextBox.Multiline = true;
            this.DocDepCodeTextBox.Name = "DocDepCodeTextBox";
            this.DocDepCodeTextBox.Size = new System.Drawing.Size(275, 32);
            this.DocDepCodeTextBox.TabIndex = 14;
            // 
            // DocYearPracticTextBox
            // 
            this.DocYearPracticTextBox.Location = new System.Drawing.Point(326, 243);
            this.DocYearPracticTextBox.Multiline = true;
            this.DocYearPracticTextBox.Name = "DocYearPracticTextBox";
            this.DocYearPracticTextBox.Size = new System.Drawing.Size(275, 32);
            this.DocYearPracticTextBox.TabIndex = 15;
            // 
            // DocShiftHoursTextBox
            // 
            this.DocShiftHoursTextBox.Location = new System.Drawing.Point(326, 296);
            this.DocShiftHoursTextBox.Multiline = true;
            this.DocShiftHoursTextBox.Name = "DocShiftHoursTextBox";
            this.DocShiftHoursTextBox.Size = new System.Drawing.Size(275, 32);
            this.DocShiftHoursTextBox.TabIndex = 16;
            this.DocShiftHoursTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView_Doctor
            // 
            this.dataGridView_Doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Doctor.Location = new System.Drawing.Point(55, 361);
            this.dataGridView_Doctor.Name = "dataGridView_Doctor";
            this.dataGridView_Doctor.RowHeadersWidth = 62;
            this.dataGridView_Doctor.RowTemplate.Height = 28;
            this.dataGridView_Doctor.Size = new System.Drawing.Size(920, 170);
            this.dataGridView_Doctor.TabIndex = 17;
            // 
            // DocFormTimer
            // 
            this.DocFormTimer.Interval = 1000;
            this.DocFormTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 565);
            this.Controls.Add(this.dataGridView_Doctor);
            this.Controls.Add(this.DocShiftHoursTextBox);
            this.Controls.Add(this.DocYearPracticTextBox);
            this.Controls.Add(this.DocDepCodeTextBox);
            this.Controls.Add(this.DocLastNameTextBox);
            this.Controls.Add(this.DocFirstNameTextBox);
            this.Controls.Add(this.DoctorIDtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.goToPatientButton);
            this.Controls.Add(this.DeleteDocButton);
            this.Controls.Add(this.UpdateDocButton);
            this.Controls.Add(this.AddDocButton);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDocButton;
        private System.Windows.Forms.Button UpdateDocButton;
        private System.Windows.Forms.Button DeleteDocButton;
        private System.Windows.Forms.Button goToPatientButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DoctorIDtextBox;
        private System.Windows.Forms.TextBox DocFirstNameTextBox;
        private System.Windows.Forms.TextBox DocLastNameTextBox;
        private System.Windows.Forms.TextBox DocDepCodeTextBox;
        private System.Windows.Forms.TextBox DocYearPracticTextBox;
        private System.Windows.Forms.TextBox DocShiftHoursTextBox;
        private System.Windows.Forms.DataGridView dataGridView_Doctor;
        private System.Windows.Forms.Timer DocFormTimer;
    }
}