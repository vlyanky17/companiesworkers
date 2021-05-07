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
    public partial class AddCompany : Form
    {

        public AddCompany()
        {
            InitializeComponent();

        } 

        private void button1_Click(object sender, EventArgs e)
        {
            if ((EditName.Text!="") &&(EditStruct.Text!=""))
            {
                Company company = new Company(EditName.Text, EditStruct.Text);
                Db Dbase = new Db();
                MySqlCommand Command = new MySqlCommand("INSERT INTO companies (name,stuct) VALUES('"+ company .CompanyName+ "','"+ company .CompanyStruct+ "'); ", Dbase.Connection());
                Dbase.OpenCon();
                Command.ExecuteNonQuery();
                Dbase.CloseCon();
            }
         
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Companies FormCompanies = new Companies();
            FormCompanies.Show();
            this.Hide();
        }
    }
}
