﻿namespace SNHU_Sched_Landing_Page
{
    partial class FriendSearch
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
            this.Title = new System.Windows.Forms.Label();
            this.firstnameSearch = new System.Windows.Forms.TextBox();
            this.lastnameSearch = new System.Windows.Forms.TextBox();
            this.firstlabel = new System.Windows.Forms.Label();
            this.lastLabel = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailSearch = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DarkBlue;
            this.Title.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(1, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(192, 77);
            this.Title.TabIndex = 0;
            this.Title.Text = "Search:";
            // 
            // firstnameSearch
            // 
            this.firstnameSearch.Location = new System.Drawing.Point(249, 79);
            this.firstnameSearch.Name = "firstnameSearch";
            this.firstnameSearch.Size = new System.Drawing.Size(100, 20);
            this.firstnameSearch.TabIndex = 1;
            // 
            // lastnameSearch
            // 
            this.lastnameSearch.Location = new System.Drawing.Point(367, 79);
            this.lastnameSearch.Name = "lastnameSearch";
            this.lastnameSearch.Size = new System.Drawing.Size(100, 20);
            this.lastnameSearch.TabIndex = 2;
            // 
            // firstlabel
            // 
            this.firstlabel.AutoSize = true;
            this.firstlabel.BackColor = System.Drawing.Color.DarkBlue;
            this.firstlabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstlabel.ForeColor = System.Drawing.Color.White;
            this.firstlabel.Location = new System.Drawing.Point(249, 55);
            this.firstlabel.Name = "firstlabel";
            this.firstlabel.Size = new System.Drawing.Size(80, 17);
            this.firstlabel.TabIndex = 3;
            this.firstlabel.Text = "First Name:";
            // 
            // lastLabel
            // 
            this.lastLabel.AutoSize = true;
            this.lastLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.lastLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLabel.ForeColor = System.Drawing.Color.White;
            this.lastLabel.Location = new System.Drawing.Point(364, 55);
            this.lastLabel.Name = "lastLabel";
            this.lastLabel.Size = new System.Drawing.Size(77, 17);
            this.lastLabel.TabIndex = 4;
            this.lastLabel.Text = "Last Name:";
            // 
            // resultsBox
            // 
            this.resultsBox.BackColor = System.Drawing.Color.DarkBlue;
            this.resultsBox.Controls.Add(this.resultsPanel);
            this.resultsBox.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBox.ForeColor = System.Drawing.Color.White;
            this.resultsBox.Location = new System.Drawing.Point(12, 148);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(776, 293);
            this.resultsBox.TabIndex = 55;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // resultsPanel
            // 
            this.resultsPanel.AutoScroll = true;
            this.resultsPanel.BackColor = System.Drawing.Color.White;
            this.resultsPanel.ForeColor = System.Drawing.Color.Black;
            this.resultsPanel.Location = new System.Drawing.Point(7, 32);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(763, 255);
            this.resultsPanel.TabIndex = 0;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.emailLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.White;
            this.emailLabel.Location = new System.Drawing.Point(486, 55);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 17);
            this.emailLabel.TabIndex = 59;
            this.emailLabel.Text = "Email:";
            // 
            // emailSearch
            // 
            this.emailSearch.Location = new System.Drawing.Point(489, 79);
            this.emailSearch.Name = "emailSearch";
            this.emailSearch.Size = new System.Drawing.Size(100, 20);
            this.emailSearch.TabIndex = 58;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(367, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 60;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(893, 9);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 61;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FriendSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(977, 541);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailSearch);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.lastLabel);
            this.Controls.Add(this.firstlabel);
            this.Controls.Add(this.lastnameSearch);
            this.Controls.Add(this.firstnameSearch);
            this.Controls.Add(this.Title);
            this.Name = "FriendSearch";
            this.Text = "Friend Search";
            this.resultsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox firstnameSearch;
        private System.Windows.Forms.TextBox lastnameSearch;
        private System.Windows.Forms.Label firstlabel;
        private System.Windows.Forms.Label lastLabel;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailSearch;
        private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button backButton;
	}
}