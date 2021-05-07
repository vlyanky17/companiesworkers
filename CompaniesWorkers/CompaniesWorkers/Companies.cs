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
    public partial class Companies : Form
    {
        public Companies()
        {
            InitializeComponent();
        }
        AddCompany FormAddCompany = new AddCompany();
  
        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddCompany.Show();
            this.Hide();
        }
        string row;
        private void Companies_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
   
            dataGridView1.Rows[0].Cells[0].Value = "Идентификатор";
            dataGridView1.Rows[0].Cells[1].Value = "Наименование";
            dataGridView1.Rows[0].Cells[3].Value = "Размер";
            dataGridView1.Rows[0].Cells[2].Value = "Форма";
            Db Dbase = new Db();
            Dbase.OpenCon();
            string cmdText = "SELECT companies.Id,companies.name,companies.stuct,COUNT(workers.Id)  FROM  workers INNER JOIN companies ON workers.WorkerCompany=companies.Id GROUP BY companies.Id";
          
            MySqlCommand Command = new MySqlCommand(cmdText, Dbase.Connection());
            MySqlDataReader reader = Command.ExecuteReader();
         
            List<string[]> data = new List<string[]>();
            while (reader.Read() )
            {
                data.Add(new string[4]);
            
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            Dbase.CloseCon();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChangeButton.Enabled = true;
            DelButton.Enabled = true;
            int rw = e.RowIndex + 1;
            row = rw.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            UpdateForm upd = new UpdateForm(row);
            upd.Show();
            this.Hide();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            Db Dbase = new Db();
            MySqlCommand Command = new MySqlCommand("DELETE * FROM companies where Id='" + row+"'", Dbase.Connection());
            Dbase.OpenCon();
            Command.ExecuteNonQuery();
            Dbase.CloseCon();
        }
    }
}
