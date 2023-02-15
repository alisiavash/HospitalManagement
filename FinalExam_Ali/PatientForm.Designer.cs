namespace FinalExam_Ali
{
    partial class PatientForm
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
            this.dataGridView_Patient = new System.Windows.Forms.DataGridView();
            this.PatientDischargeStatTextBox = new System.Windows.Forms.TextBox();
            this.PatientSectionTextBox = new System.Windows.Forms.TextBox();
            this.PatientDepCodeTextBox = new System.Windows.Forms.TextBox();
            this.PatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatientIDtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeletePatientButton = new System.Windows.Forms.Button();
            this.UpdatePatientButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PatientBalanceTextBox = new System.Windows.Forms.TextBox();
            this.PatFormTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patient)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Patient
            // 
            this.dataGridView_Patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Patient.Location = new System.Drawing.Point(23, 439);
            this.dataGridView_Patient.Name = "dataGridView_Patient";
            this.dataGridView_Patient.RowHeadersWidth = 62;
            this.dataGridView_Patient.RowTemplate.Height = 28;
            this.dataGridView_Patient.Size = new System.Drawing.Size(1014, 213);
            this.dataGridView_Patient.TabIndex = 35;
            // 
            // PatientDischargeStatTextBox
            // 
            this.PatientDischargeStatTextBox.Location = new System.Drawing.Point(318, 301);
            this.PatientDischargeStatTextBox.Multiline = true;
            this.PatientDischargeStatTextBox.Name = "PatientDischargeStatTextBox";
            this.PatientDischargeStatTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientDischargeStatTextBox.TabIndex = 34;
            // 
            // PatientSectionTextBox
            // 
            this.PatientSectionTextBox.Location = new System.Drawing.Point(318, 248);
            this.PatientSectionTextBox.Multiline = true;
            this.PatientSectionTextBox.Name = "PatientSectionTextBox";
            this.PatientSectionTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientSectionTextBox.TabIndex = 33;
            // 
            // PatientDepCodeTextBox
            // 
            this.PatientDepCodeTextBox.Location = new System.Drawing.Point(318, 193);
            this.PatientDepCodeTextBox.Multiline = true;
            this.PatientDepCodeTextBox.Name = "PatientDepCodeTextBox";
            this.PatientDepCodeTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientDepCodeTextBox.TabIndex = 32;
            // 
            // PatientLastNameTextBox
            // 
            this.PatientLastNameTextBox.Location = new System.Drawing.Point(318, 141);
            this.PatientLastNameTextBox.Multiline = true;
            this.PatientLastNameTextBox.Name = "PatientLastNameTextBox";
            this.PatientLastNameTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientLastNameTextBox.TabIndex = 31;
            // 
            // PatientFirstNameTextBox
            // 
            this.PatientFirstNameTextBox.Location = new System.Drawing.Point(318, 90);
            this.PatientFirstNameTextBox.Multiline = true;
            this.PatientFirstNameTextBox.Name = "PatientFirstNameTextBox";
            this.PatientFirstNameTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientFirstNameTextBox.TabIndex = 30;
            // 
            // PatientIDtextBox
            // 
            this.PatientIDtextBox.Location = new System.Drawing.Point(318, 38);
            this.PatientIDtextBox.Multiline = true;
            this.PatientIDtextBox.Name = "PatientIDtextBox";
            this.PatientIDtextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientIDtextBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 32);
            this.label6.TabIndex = 28;
            this.label6.Text = "Discharge Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Section Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Department Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Lastname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 24;
            this.label2.Text = "Firstname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "PatientID:";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(762, 233);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(205, 50);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeletePatientButton
            // 
            this.DeletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePatientButton.Location = new System.Drawing.Point(762, 173);
            this.DeletePatientButton.Name = "DeletePatientButton";
            this.DeletePatientButton.Size = new System.Drawing.Size(205, 42);
            this.DeletePatientButton.TabIndex = 20;
            this.DeletePatientButton.Text = "Delete";
            this.DeletePatientButton.UseVisualStyleBackColor = true;
            this.DeletePatientButton.Click += new System.EventHandler(this.DeletePatientButton_Click);
            // 
            // UpdatePatientButton
            // 
            this.UpdatePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatePatientButton.Location = new System.Drawing.Point(762, 110);
            this.UpdatePatientButton.Name = "UpdatePatientButton";
            this.UpdatePatientButton.Size = new System.Drawing.Size(205, 42);
            this.UpdatePatientButton.TabIndex = 19;
            this.UpdatePatientButton.Text = "Update";
            this.UpdatePatientButton.UseVisualStyleBackColor = true;
            this.UpdatePatientButton.Click += new System.EventHandler(this.UpdatePatientButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPatientButton.Location = new System.Drawing.Point(762, 38);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(205, 42);
            this.AddPatientButton.TabIndex = 18;
            this.AddPatientButton.Text = "Add Patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 32);
            this.label7.TabIndex = 36;
            this.label7.Text = "Balance:";
            // 
            // PatientBalanceTextBox
            // 
            this.PatientBalanceTextBox.Location = new System.Drawing.Point(318, 360);
            this.PatientBalanceTextBox.Multiline = true;
            this.PatientBalanceTextBox.Name = "PatientBalanceTextBox";
            this.PatientBalanceTextBox.Size = new System.Drawing.Size(275, 32);
            this.PatientBalanceTextBox.TabIndex = 37;
            // 
            // PatFormTimer
            // 
            this.PatFormTimer.Tick += new System.EventHandler(this.PatFormTimer_Tick);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 664);
            this.Controls.Add(this.PatientBalanceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_Patient);
            this.Controls.Add(this.PatientDischargeStatTextBox);
            this.Controls.Add(this.PatientSectionTextBox);
            this.Controls.Add(this.PatientDepCodeTextBox);
            this.Controls.Add(this.PatientLastNameTextBox);
            this.Controls.Add(this.PatientFirstNameTextBox);
            this.Controls.Add(this.PatientIDtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DeletePatientButton);
            this.Controls.Add(this.UpdatePatientButton);
            this.Controls.Add(this.AddPatientButton);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Patient;
        private System.Windows.Forms.TextBox PatientDischargeStatTextBox;
        private System.Windows.Forms.TextBox PatientSectionTextBox;
        private System.Windows.Forms.TextBox PatientDepCodeTextBox;
        private System.Windows.Forms.TextBox PatientLastNameTextBox;
        private System.Windows.Forms.TextBox PatientFirstNameTextBox;
        private System.Windows.Forms.TextBox PatientIDtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeletePatientButton;
        private System.Windows.Forms.Button UpdatePatientButton;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PatientBalanceTextBox;
        private System.Windows.Forms.Timer PatFormTimer;
    }
}