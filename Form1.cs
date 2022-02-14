using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using MySqlConnector;

namespace PiesDB
{
    public enum Person
    {
        JANEK = 0,
        BARTEK = 1
    }
    public partial class DB : Form
    {
        MySqlConnection connection;
        public DB()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Janek_Click(object sender, EventArgs e)
        {
            StreamWriter dateAndName = new StreamWriter(@".\janek.txt", true);
            dateAndName.Write(DateTime.Now);
            dateAndName.Write(" Janek\n");
            dateAndName.Close();
            DataBaseInsert(Person.JANEK, DateTime.Now.ToString());
        }
        private void Bartek_Click(object sender, EventArgs e)
        {
            StreamWriter dateAndName = new StreamWriter(@".\bartek.txt", true);
            dateAndName.Write(DateTime.Now);
            dateAndName.Write(" Bartek\n");
            dateAndName.Close();
            DataBaseInsert(Person.BARTEK, DateTime.Now.ToString());
        }
        private void DB_Load(object sender, EventArgs e)
        {
            DataBaseLoad();
        }
        private void DataBaseInsert(Person person, string date)
        {
            if (!ConnectToDataBase())
                return;

            MySqlCommand query = new MySqlCommand("INSERT INTO `records` (`name`,`date`) VALUES (@name,@date)", connection);
            query.Parameters.AddWithValue("name", (int)person);
            query.Parameters.AddWithValue("date", date);
            query.ExecuteNonQuery();
            DataBaseLoad();
        }
        private void DataBaseLoad()
        {
           if (!ConnectToDataBase())
                return;

            MySqlCommand query = new MySqlCommand("SELECT * FROM records ORDER BY id DESC", connection);
            MySqlDataReader reader = query.ExecuteReader();
            janekListBox.Items.Clear();
            bartekListBox.Items.Clear();
            while (reader.Read())
            {
                switch(reader.GetValue(1))
                {
                    case 0:
                        janekListBox.Items.Add("(Janek) " + reader.GetValue(2));
                        break;
                    case 1:
                        bartekListBox.Items.Add("(Bartek) " + reader.GetValue(2));
                        break;
                }
            }
            liczba.Text = "Janek:  " + janekListBox.Items.Count + "\nBartek: " + bartekListBox.Items.Count;

            if (janekListBox.Items.Count >= bartekListBox.Items.Count)
                kto.Text = "Bartek";
            else
                kto.Text = "Janek";
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            DataBaseLoad();
        }
        private bool ConnectToDataBase()
        { 
            if (connection !=null && connection.State == ConnectionState.Open) 
                connection.Close();
            // I won't provide userid and password for obvious reasons, you can try with your owen database
            connection = new MySqlConnection("Server=d'sercer';User ID='useerID';Password='password';Database='database name'");
            try 
            { 
                connection.Open(); 
            } 
            catch(Exception e) 
            { 
                return false; 
            } 
            return true;
        }

        private void DB_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBoxBartek_Leave(object sender, EventArgs e)
        {
            if (textBoxBartek.Text != "")
            {
                DataBaseInsert(Person.BARTEK, textBoxBartek.Text);
                StreamWriter dateAndName = new StreamWriter(@".\bartek.txt", true);
                dateAndName.Write(textBoxBartek.Text);
                dateAndName.Write(" Bartek\n");
                dateAndName.Close();
            }
            textBoxBartek.Text = "";
        }

        private void textBoxJanek_Leave(object sender, EventArgs e)
        {
            if (textBoxJanek.Text != "")
            {
                DataBaseInsert(Person.JANEK, textBoxJanek.Text);
                StreamWriter dateAndName = new StreamWriter(@".\janek.txt", true);
                dateAndName.Write(textBoxJanek.Text);
                dateAndName.Write(" Janek\n");
                dateAndName.Close();

            }
            textBoxJanek.Text = "";
        }
    }
}

