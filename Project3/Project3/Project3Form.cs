using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Project3Form : Form
    {
        public Project3Form()
        {
            InitializeComponent();
        }

        private void Project3Form_Load(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int numGames = 0;

            if (string.IsNullOrEmpty(this.nGames.Text) || string.IsNullOrWhiteSpace(this.nGames.Text) || !int.TryParse(this.nGames.Text.ToString(), out numGames) || Regex.Matches(seednum.Text, @"[a-zA-Z]").Count != 0)
            {
                MessageBox.Show("Invalid input, Please Enter integer value for input!");   //Throw this message if empty
            }
            else 
            {
            
            }
        }
    }
}
