namespace SNHU_Sched_Landing_Page
{
    partial class HomePage
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
			this.usernameInput = new System.Windows.Forms.TextBox();
			this.passwordInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.LoginButton = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.signUp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// usernameInput
			// 
			this.usernameInput.Location = new System.Drawing.Point(638, 32);
			this.usernameInput.Margin = new System.Windows.Forms.Padding(2);
			this.usernameInput.Name = "usernameInput";
			this.usernameInput.Size = new System.Drawing.Size(104, 20);
			this.usernameInput.TabIndex = 0;
			this.usernameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// passwordInput
			// 
			this.passwordInput.Location = new System.Drawing.Point(638, 62);
			this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
			this.passwordInput.Name = "passwordInput";
			this.passwordInput.PasswordChar = '*';
			this.passwordInput.Size = new System.Drawing.Size(104, 20);
			this.passwordInput.TabIndex = 1;
			this.passwordInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(556, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label2.Location = new System.Drawing.Point(556, 59);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.pictureBox1.Location = new System.Drawing.Point(26, 99);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(426, 276);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.DodgerBlue;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Location = new System.Drawing.Point(654, 89);
			this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(76, 23);
			this.LoginButton.TabIndex = 5;
			this.LoginButton.Text = "Log In";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(108, 206);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(263, 62);
			this.textBox3.TabIndex = 6;
			this.textBox3.Text = "THIS IS WHERE THE SCROLLING IMAGES GO";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.CornflowerBlue;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.ForeColor = System.Drawing.SystemColors.Window;
			this.textBox4.Location = new System.Drawing.Point(26, 11);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(282, 73);
			this.textBox4.TabIndex = 7;
			this.textBox4.Text = "Welcome";
			this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
			// 
			// signUp
			// 
			this.signUp.Location = new System.Drawing.Point(654, 130);
			this.signUp.Name = "signUp";
			this.signUp.Size = new System.Drawing.Size(75, 23);
			this.signUp.TabIndex = 8;
			this.signUp.Text = "Sign Up";
			this.signUp.UseVisualStyleBackColor = true;
			this.signUp.Click += new System.EventHandler(this.signUp_Click);
			// 
			// HomePage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(977, 541);
			this.Controls.Add(this.signUp);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.usernameInput);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordInput);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "HomePage";
			this.Text = "Home Page";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button signUp;
	}
}

