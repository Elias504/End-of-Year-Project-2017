using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Year_Project__E_Voting_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Add_Candidate ss = new Add_Candidate();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Election ss = new Election();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login ss = new Login();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Add_Candidate ss = new Add_Candidate();
            ss.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Voter ss = new Add_Voter();
            ss.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Results1 ss = new View_Results1();
            ss.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_authentication ss = new Voter_authentication();
            ss.Show();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}
