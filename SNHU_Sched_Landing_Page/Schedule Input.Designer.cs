namespace SNHU_Sched_Landing_Page
{
	partial class Schedule_Input
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
            this.AddClassLabel = new System.Windows.Forms.Label();
            this.ClassStartTime = new System.Windows.Forms.ComboBox();
            this.ClassID = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.ClassIDText = new System.Windows.Forms.Label();
            this.AddAnotherClass = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.doubleBlockcheckBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.firstDayLabel = new System.Windows.Forms.Label();
            this.secondDayLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.oneDaycheckBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddClassLabel
            // 
            this.AddClassLabel.AutoSize = true;
            this.AddClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassLabel.Location = new System.Drawing.Point(540, 43);
            this.AddClassLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AddClassLabel.Name = "AddClassLabel";
            this.AddClassLabel.Size = new System.Drawing.Size(632, 122);
            this.AddClassLabel.TabIndex = 0;
            this.AddClassLabel.Text = "Add a Class";
            this.AddClassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClassStartTime
            // 
            this.ClassStartTime.DisplayMember = "8:00";
            this.ClassStartTime.FormattingEnabled = true;
            this.ClassStartTime.Items.AddRange(new object[] {
            "8:00am",
            "9:30am",
            "11:00am",
            "12:30pm",
            "2:00pm",
            "3:30pm",
            "5:00pm",
            "6:30pm"});
            this.ClassStartTime.Location = new System.Drawing.Point(685, 381);
            this.ClassStartTime.Margin = new System.Windows.Forms.Padding(6);
            this.ClassStartTime.Name = "ClassStartTime";
            this.ClassStartTime.Size = new System.Drawing.Size(219, 32);
            this.ClassStartTime.TabIndex = 1;
            this.ClassStartTime.SelectedIndexChanged += new System.EventHandler(this.ClassStartTime_SelectedIndexChanged);
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(273, 384);
            this.ClassID.Margin = new System.Windows.Forms.Padding(6);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(180, 29);
            this.ClassID.TabIndex = 2;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(519, 380);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(145, 32);
            this.StartTimeLabel.TabIndex = 3;
            this.StartTimeLabel.Text = "Start Time";
            // 
            // ClassIDText
            // 
            this.ClassIDText.AutoSize = true;
            this.ClassIDText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassIDText.Location = new System.Drawing.Point(133, 381);
            this.ClassIDText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ClassIDText.Name = "ClassIDText";
            this.ClassIDText.Size = new System.Drawing.Size(128, 32);
            this.ClassIDText.TabIndex = 4;
            this.ClassIDText.Text = "Class ID:";
            // 
            // AddAnotherClass
            // 
            this.AddAnotherClass.Location = new System.Drawing.Point(817, 539);
            this.AddAnotherClass.Margin = new System.Windows.Forms.Padding(6);
            this.AddAnotherClass.Name = "AddAnotherClass";
            this.AddAnotherClass.Size = new System.Drawing.Size(180, 60);
            this.AddAnotherClass.TabIndex = 5;
            this.AddAnotherClass.Text = "Add Another Class";
            this.AddAnotherClass.UseVisualStyleBackColor = true;
            this.AddAnotherClass.Click += new System.EventHandler(this.AddAnotherClass_Click);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(817, 626);
            this.Done.Margin = new System.Windows.Forms.Padding(6);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(180, 60);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // doubleBlockcheckBox1
            // 
            this.doubleBlockcheckBox1.AutoSize = true;
            this.doubleBlockcheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBlockcheckBox1.Location = new System.Drawing.Point(685, 422);
            this.doubleBlockcheckBox1.Name = "doubleBlockcheckBox1";
            this.doubleBlockcheckBox1.Size = new System.Drawing.Size(222, 36);
            this.doubleBlockcheckBox1.TabIndex = 7;
            this.doubleBlockcheckBox1.Text = "Double block?";
            this.doubleBlockcheckBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBox1.Location = new System.Drawing.Point(1252, 380);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 32);
            this.comboBox1.TabIndex = 8;
            // 
            // firstDayLabel
            // 
            this.firstDayLabel.AutoSize = true;
            this.firstDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDayLabel.Location = new System.Drawing.Point(1013, 380);
            this.firstDayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstDayLabel.Name = "firstDayLabel";
            this.firstDayLabel.Size = new System.Drawing.Size(237, 32);
            this.firstDayLabel.TabIndex = 9;
            this.firstDayLabel.Text = "First Day of Week";
            // 
            // secondDayLabel
            // 
            this.secondDayLabel.AutoSize = true;
            this.secondDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondDayLabel.Location = new System.Drawing.Point(961, 463);
            this.secondDayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.secondDayLabel.Name = "secondDayLabel";
            this.secondDayLabel.Size = new System.Drawing.Size(279, 32);
            this.secondDayLabel.TabIndex = 10;
            this.secondDayLabel.Text = "Second Day of Week";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.comboBox2.Location = new System.Drawing.Point(1252, 463);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(219, 32);
            this.comboBox2.TabIndex = 11;
            // 
            // oneDaycheckBox2
            // 
            this.oneDaycheckBox2.AutoSize = true;
            this.oneDaycheckBox2.Location = new System.Drawing.Point(1480, 386);
            this.oneDaycheckBox2.Name = "oneDaycheckBox2";
            this.oneDaycheckBox2.Size = new System.Drawing.Size(236, 29);
            this.oneDaycheckBox2.TabIndex = 12;
            this.oneDaycheckBox2.Text = "If only one day of week";
            this.oneDaycheckBox2.UseVisualStyleBackColor = true;
            // 
            // Schedule_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1740, 964);
            this.Controls.Add(this.oneDaycheckBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.secondDayLabel);
            this.Controls.Add(this.firstDayLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.doubleBlockcheckBox1);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.AddAnotherClass);
            this.Controls.Add(this.ClassIDText);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.ClassID);
            this.Controls.Add(this.ClassStartTime);
            this.Controls.Add(this.AddClassLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Schedule_Input";
            this.Text = "Schedule_Input";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label AddClassLabel;
		private System.Windows.Forms.ComboBox ClassStartTime;
		private System.Windows.Forms.TextBox ClassID;
		private System.Windows.Forms.Label StartTimeLabel;
		private System.Windows.Forms.Label ClassIDText;
		private System.Windows.Forms.Button AddAnotherClass;
		private System.Windows.Forms.Button Done;
        private System.Windows.Forms.CheckBox doubleBlockcheckBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label firstDayLabel;
        private System.Windows.Forms.Label secondDayLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox oneDaycheckBox2;
    }
}