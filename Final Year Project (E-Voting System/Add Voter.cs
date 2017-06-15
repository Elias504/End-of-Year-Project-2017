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
using System.IO;

namespace Final_Year_Project__E_Voting_System
{
    public partial class Add_Voter : Form
    {
        public Add_Voter()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            textbox1.Text = "";
            textbox2.Clear();
            textbox3.Text = "";
            textbox4.Clear();
            textBox5.Text = "";
            pictureBox1.ResetText();

            textbox1.Focus();
        }

        
        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "insert into voter (voter_id,voter_name,mobile_number,address,image)  values ('" + this.textbox1.Text + "','" + this.textbox2.Text + "','" + this.textbox3.Text + "','" + this.textbox4.Text + "',@IMG) ";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();

                cmdDatebase.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                myReader = cmdDatebase.ExecuteReader();

                MessageBox.Show("inserted");
                textbox1.Text = "";
                textbox2.Clear();
                textbox3.Text = "";
                textbox4.Clear();
                textBox5.Clear();
                pictureBox1.Refresh();
                textbox1.Focus();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|ALL Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picpath = dlg.FileName.ToString();
                textBox5.Text = picpath;
                pictureBox1.ImageLocation = picpath;
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "update voter  set voter_id='" + this.textbox1.Text + "',voter_name='" + this.textbox2.Text + "',mobile_number='" + this.textbox3.Text + "',address='" + this.textbox3.Text + "' voter_id='" + this.textbox1.Text + "' ";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();
                MessageBox.Show("updated");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "delete from voter  where voter_id='" + this.textbox1.Text + "' ";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();
                MessageBox.Show("Deleted");
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
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

        private void Add_Voter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINALDataSet9.voter' table. You can move, or remove it, as needed.
            this.voterTableAdapter.Fill(this.fINALDataSet9.voter);

        }
    }
}
