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
            this.SuspendLayout();
            // 
            // AddClassLabel
            // 
            this.AddClassLabel.AutoSize = true;
            this.AddClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClassLabel.Location = new System.Drawing.Point(625, 36);
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
            this.ClassStartTime.Location = new System.Drawing.Point(1058, 369);
            this.ClassStartTime.Margin = new System.Windows.Forms.Padding(6);
            this.ClassStartTime.Name = "ClassStartTime";
            this.ClassStartTime.Size = new System.Drawing.Size(219, 32);
            this.ClassStartTime.TabIndex = 1;
            this.ClassStartTime.SelectedIndexChanged += new System.EventHandler(this.ClassStartTime_SelectedIndexChanged);
            // 
            // ClassID
            // 
            this.ClassID.Location = new System.Drawing.Point(646, 372);
            this.ClassID.Margin = new System.Windows.Forms.Padding(6);
            this.ClassID.Name = "ClassID";
            this.ClassID.Size = new System.Drawing.Size(180, 29);
            this.ClassID.TabIndex = 2;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(901, 368);
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
            this.ClassIDText.Location = new System.Drawing.Point(506, 369);
            this.ClassIDText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ClassIDText.Name = "ClassIDText";
            this.ClassIDText.Size = new System.Drawing.Size(128, 32);
            this.ClassIDText.TabIndex = 4;
            this.ClassIDText.Text = "Class ID:";
            // 
            // AddAnotherClass
            // 
            this.AddAnotherClass.Location = new System.Drawing.Point(799, 567);
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
            this.Done.Location = new System.Drawing.Point(799, 662);
            this.Done.Margin = new System.Windows.Forms.Padding(6);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(180, 60);
            this.Done.TabIndex = 6;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Schedule_Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1740, 964);
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
	}
}