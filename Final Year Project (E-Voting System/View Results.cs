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
    public partial class View_Results : Form
    {
        public View_Results()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void View_Results_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINALDataSet2.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.fINALDataSet2.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet1.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.fINALDataSet1.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.fINALDataSet.candidate);

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ss = new Home();
            ss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
