﻿namespace SNHU_Sched_Landing_Page
{
    partial class CreateNewUser
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
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.GradYear = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailColor = new System.Windows.Forms.PictureBox();
            this.PasswordColor = new System.Windows.Forms.PictureBox();
            this.ConfirmPasswordColor = new System.Windows.Forms.PictureBox();
            this.GradYearColor = new System.Windows.Forms.PictureBox();
            this.StudentIDColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmailColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradYearColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIDColor)).BeginInit();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Email.Location = new System.Drawing.Point(429, 139);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(253, 20);
            this.Email.TabIndex = 0;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Password.Location = new System.Drawing.Point(429, 178);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(253, 20);
            this.Password.TabIndex = 1;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConfirmPassword.Location = new System.Drawing.Point(429, 217);
            this.ConfirmPassword.MaxLength = 20;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PasswordChar = '*';
            this.ConfirmPassword.Size = new System.Drawing.Size(253, 20);
            this.ConfirmPassword.TabIndex = 2;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.ConfirmPassword_TextChanged);
            // 
            // GradYear
            // 
            this.GradYear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GradYear.Location = new System.Drawing.Point(429, 253);
            this.GradYear.Name = "GradYear";
            this.GradYear.Size = new System.Drawing.Size(253, 20);
            this.GradYear.TabIndex = 3;
            this.GradYear.TextChanged += new System.EventHandler(this.GradYear_TextChanged);
            // 
            // StudentID
            // 
            this.StudentID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StudentID.Location = new System.Drawing.Point(429, 290);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(253, 20);
            this.StudentID.TabIndex = 4;
            this.StudentID.TextChanged += new System.EventHandler(this.StudentID_TextChanged);
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(516, 332);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(84, 27);
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(372, 137);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(55, 19);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Grad Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(341, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student ID:";
            // 
            // EmailColor
            // 
            this.EmailColor.Location = new System.Drawing.Point(688, 139);
            this.EmailColor.Name = "EmailColor";
            this.EmailColor.Size = new System.Drawing.Size(16, 16);
            this.EmailColor.TabIndex = 11;
            this.EmailColor.TabStop = false;
            // 
            // PasswordColor
            // 
            this.PasswordColor.Location = new System.Drawing.Point(688, 177);
            this.PasswordColor.Name = "PasswordColor";
            this.PasswordColor.Size = new System.Drawing.Size(16, 16);
            this.PasswordColor.TabIndex = 12;
            this.PasswordColor.TabStop = false;
            // 
            // ConfirmPasswordColor
            // 
            this.ConfirmPasswordColor.Location = new System.Drawing.Point(688, 217);
            this.ConfirmPasswordColor.Name = "ConfirmPasswordColor";
            this.ConfirmPasswordColor.Size = new System.Drawing.Size(16, 16);
            this.ConfirmPasswordColor.TabIndex = 13;
            this.ConfirmPasswordColor.TabStop = false;
            // 
            // GradYearColor
            // 
            this.GradYearColor.Location = new System.Drawing.Point(688, 253);
            this.GradYearColor.Name = "GradYearColor";
            this.GradYearColor.Size = new System.Drawing.Size(16, 16);
            this.GradYearColor.TabIndex = 14;
            this.GradYearColor.TabStop = false;
            // 
            // StudentIDColor
            // 
            this.StudentIDColor.Location = new System.Drawing.Point(688, 290);
            this.StudentIDColor.Name = "StudentIDColor";
            this.StudentIDColor.Size = new System.Drawing.Size(16, 16);
            this.StudentIDColor.TabIndex = 15;
            this.StudentIDColor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(325, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(412, 77);
            this.label5.TabIndex = 16;
            this.label5.Text = "Create an Account";
            // 
            // CreateNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(977, 541);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StudentIDColor);
            this.Controls.Add(this.GradYearColor);
            this.Controls.Add(this.ConfirmPasswordColor);
            this.Controls.Add(this.PasswordColor);
            this.Controls.Add(this.EmailColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.GradYear);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CreateNewUser";
            this.Text = "New User";
            ((System.ComponentModel.ISupportInitialize)(this.EmailColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmPasswordColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradYearColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentIDColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.TextBox GradYear;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox EmailColor;
        private System.Windows.Forms.PictureBox PasswordColor;
        private System.Windows.Forms.PictureBox ConfirmPasswordColor;
        private System.Windows.Forms.PictureBox GradYearColor;
        private System.Windows.Forms.PictureBox StudentIDColor;
        private System.Windows.Forms.Label label5;
    }
}