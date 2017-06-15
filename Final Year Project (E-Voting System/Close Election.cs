using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Final_Year_Project__E_Voting_System
{
    public partial class Close_Election : Form
    {
        public Close_Election()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Voter_authentication ss = new Voter_authentication();
            ss.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=DOROTHY; database=FINAL;");
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) From admin Where Admin_ID ='" + textBox1.Text + "' And Password= '" + textBox3.Text + "'", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                View_Results1 ss = new View_Results1();
                ss.Show();

            }
            else
            {
                MessageBox.Show("If you and the Election admin please try again, if you are a voter ,please not, an attempt to compromise the election is illegal, please go back to the Election Page!!!!!");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
