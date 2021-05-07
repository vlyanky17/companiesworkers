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
    public partial class UpdateForm : Form
    {
        public UpdateForm(string row)
        {
            InitializeComponent();
            this.row = row;
        }
        string row;
        private void UpdateForm_Load(object sender, EventArgs e)
        {
         
            Db Dbase = new Db();

            string cmdText = "select * from companies where Id='"+row+"'";
            Dbase.OpenCon();
            MySqlCommand Command = new MySqlCommand(cmdText, Dbase.Connection());
            MySqlDataReader reader = Command.ExecuteReader();

            while (reader.Read())
            {
                textBox1.Text = reader[1].ToString();
                textBox2.Text = reader[2].ToString();
            }
            Dbase.CloseCon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Companies FormCompanies = new Companies();
            FormCompanies.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                Company company = new Company(textBox1.Text, textBox2.Text);
                Db Dbase = new Db();
                MySqlCommand Command = new MySqlCommand("UPDATE  companies SET  name='" + company.CompanyName + "', stuct='" + company.CompanyStruct + "' where Id=" + row, Dbase.Connection());
                Dbase.OpenCon();
                Command.ExecuteNonQuery();
                Dbase.CloseCon();
                Companies FormCompanies = new Companies();
                FormCompanies.Show();
                this.Hide();
            }
        }
    }
}
