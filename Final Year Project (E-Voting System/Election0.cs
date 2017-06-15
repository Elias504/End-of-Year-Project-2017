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
    public partial class Election : Form
    {
        public Election()
        {
            InitializeComponent();
            fillCombo1();
        }

        void fillCombo1()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'President') ";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();
               
                while (myReader.Read())
                {
                    string sName = myReader.GetString("candidate_name");
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Election_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINALDataSet6.candidate' table. You can move, or remove it, as needed.
             this.candidateTableAdapter4.Fill(this.fINALDataSet6.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet5.candidate' table. You can move, or remove it, as needed.
             this.candidateTableAdapter3.Fill(this.fINALDataSet5.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet4.candidate' table. You can move, or remove it, as needed.
             this.candidateTableAdapter2.Fill(this.fINALDataSet4.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet3.candidate' table. You can move, or remove it, as needed.
             this.candidateTableAdapter1.Fill(this.fINALDataSet3.candidate);
            // TODO: This line of code loads data into the 'fINALDataSet.candidate' table. You can move, or remove it, as needed.
             this.candidateTableAdapter.Fill(this.fINALDataSet.candidate);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter1.FillBy(this.fINALDataSet3.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "update candidate  set vote = vote +1 where  candidate_id = '" + this.comboBox1.Text + "' ";

            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();

                MessageBox.Show("vote cast");

                this.Hide();
                Voter_authentication ss = new Voter_authentication();
                ss.Show();

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
            Close_Election ss = new Close_Election();
            ss.Show();
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter2.FillBy(this.fINALDataSet4.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter3.FillBy(this.fINALDataSet5.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {
            try
            {
                this.candidateTableAdapter4.FillBy(this.fINALDataSet6.candidate);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

       
    }
}
