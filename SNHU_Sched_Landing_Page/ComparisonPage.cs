using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNHU_Sched_Landing_Page
{
    public partial class ComparisonPage : Form
    {
        public ComparisonPage()
        {
            InitializeComponent();
            for (int i = 0; i < 60; i++)
            {
                Button button = new Button();
                button.Name = $"Button{i}";
                button.Text = i.ToString();
                button.Location = new Point(10, friendPanel.Controls.Count * 25);
                button.Click += (s, e) => 
                {
                    string message = Convert.ToString(i);
                    MessageBox.Show(message);
                };

                friendPanel.Controls.Add(button);
            }
        }

        private void ComparisonPage_Load(object sender, EventArgs e)
        {

        }

        private void addFriendButton_Click(object sender, EventArgs e)
        {
            AddFriends addfreinds = new AddFriends();
            addfreinds.ShowDialog();
        }
    }
}
