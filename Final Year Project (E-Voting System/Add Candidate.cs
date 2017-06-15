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
    public partial class Add_Candidate : Form
    {
        public Add_Candidate()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
         void Fillcombo()
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ss = new Home();
            ss.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            textbox2.Text = "";
            textbox1.Clear();
            textbox3.Text = "";
            textbox1.Clear();
            textbox4.Text = "";
            pictureBox1.ResetText();

            textbox2.Focus();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(this.textBox5.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "insert into candidate (candidate_id,candidate_name,mobile_number,about_candidate, candidacy,image)  values ('" + this.textbox2.Text + "','" + this.textbox1.Text + "','" + this.textbox3.Text + "','" + this.textbox4.Text + "','" + this.comboBox1.Text + "',@IMG) ";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();

                cmdDatebase.Parameters.Add(new MySqlParameter("@IMG", imageBt));

                myReader = cmdDatebase.ExecuteReader();

                MessageBox.Show("inserted");
                textbox2.Text = "";
                textbox1.Clear();
                textbox3.Text = "";
                textbox1.Clear();
                textBox5.Clear();
                textbox4.Text = "";
                pictureBox1.Refresh();

                textbox2.Focus();
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "update candidate  set candidate_id='" + this.textbox2.Text + "', candidate_name='" + this.textbox1.Text + "', mobile_number='" + this.textbox3.Text + "',about_candidate='" + this.textbox4.Text + "' where candidate_id='"+this.textbox2.Text+"' ";
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
            string Query = "delete from candidate  where candidate_id='" + this.textbox2.Text + "' ";
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ss = new Home();
            ss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Candidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINALDataSet8.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.fINALDataSet8.candidate);

        }
    }
}
