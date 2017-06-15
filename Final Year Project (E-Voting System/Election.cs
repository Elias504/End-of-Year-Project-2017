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

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;


            fillCombo1();
            fillCombo2();
            fillCombo3();
            fillCombo4();
            fillCombo5();
            fillCombo6();

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
        void fillCombo2()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'Vice President') ";
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
                    comboBox2.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void fillCombo3()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'Sectritary General') ";
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
                    comboBox3.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void fillCombo4()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'Treasurer') ";
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
                    comboBox4.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        void fillCombo5()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'Publicity Secritary') ";
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
                    comboBox5.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        void fillCombo6()
        {

            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "SELECT * FROM candidate WHERE(candidacy = 'Commitee Member') ";
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
                    comboBox6.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void votePresident()
        {          string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE       candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox1.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();
                MessageBox.Show("VOTE CAST");

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

        void voteVicePresident()
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE       candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox2.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();
              
                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        void voteSectritaryGeneral()
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE       candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox3.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void voteTreasurer()
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox4.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void votePublicitySecritary()
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox5.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        void voteCommiteeMember()
        {
            string conString = "datasource=localhost;port=3306;username=root; password=DOROTHY;database=FINAL;";
            string Query = "UPDATE candidate SET vote = vote + 1 WHERE(candidate_name = '" + this.comboBox6.Text + "')";
            MySqlConnection conDatabase = new MySqlConnection(conString);
            MySqlCommand cmdDatebase = new MySqlCommand(Query, conDatabase);
            MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatebase.ExecuteReader();

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }






        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            votePresident();
            voteVicePresident();
            voteSectritaryGeneral();
            voteTreasurer();
            votePublicitySecritary();
            voteCommiteeMember();

        }
    }
}
