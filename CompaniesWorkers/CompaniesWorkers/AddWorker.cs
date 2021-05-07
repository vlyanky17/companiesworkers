using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CompaniesWorkers
{
    public partial class AddWorker : Form
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            Db Dbase = new Db();
            Dbase.OpenCon();
            string cmdText = "SELECT name  FROM  companies";

            MySqlCommand Command = new MySqlCommand(cmdText, Dbase.Connection());
            MySqlDataReader reader = Command.ExecuteReader();

          
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());

            }
            reader.Close();
            Dbase.CloseCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != "") && (textBox5.Text != ""))
            {
                Db Dbase = new Db();
                Dbase.OpenCon();
                string cmdText = "SELECT Id  FROM  companies WHERE name='" + comboBox1.Text+"'";
    
                MySqlCommand Command = new MySqlCommand(cmdText, Dbase.Connection());
                MySqlDataReader reader = Command.ExecuteReader();
                string ID="";
                while (reader.Read())
                { ID  = reader[0].ToString(); }
                reader.Close();
                Worker worker = new Worker(textBox1.Text, textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text, ID);
           
                MySqlCommand AddCommand = new MySqlCommand("INSERT INTO workers (WorkerSurname,WorkerName,WorkerPatronymic,WorkerDate,WorkerSpecific,WorkerCompany) VALUES('" + worker.WorkerSurname + "','" + worker.WorkerName + "','" + worker.WorkerPatronymic + "','" + worker.WorkerDate + "','" + worker.WorkerSpecific + "','" + worker.WorkerCompany+     "'); ", Dbase.Connection());

                AddCommand.ExecuteNonQuery();
                Dbase.CloseCon();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.Show();
            this.Hide();
        }
    }
}
