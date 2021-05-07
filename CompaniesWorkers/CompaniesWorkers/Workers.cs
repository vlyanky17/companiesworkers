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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }
        AddWorker FormAddWorker = new AddWorker();
        private void AddButton_Click(object sender, EventArgs e)
        {
            FormAddWorker.Show();
            this.Hide();
        }
        string row;
        private void Workers_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Rows[0].Cells[0].Value = "Идентификатор";
            dataGridView1.Rows[0].Cells[1].Value = "Фамилия";
            dataGridView1.Rows[0].Cells[2].Value = "Имя";
            dataGridView1.Rows[0].Cells[3].Value = "Отчество";
            dataGridView1.Rows[0].Cells[4].Value = "Дата";
            dataGridView1.Rows[0].Cells[5].Value = "Должность";
            dataGridView1.Rows[0].Cells[6].Value = "Компания";
            Db Dbase = new Db();
            Dbase.OpenCon();
            string cmdText = "SELECT workers.Id,workers.WorkerSurname,workers.WorkerName,workers.WorkerPatronymic,workers.WorkerDate,workers.WorkerSpecific,companies.name  FROM  workers INNER JOIN companies ON workers.WorkerCompany=companies.Id GROUP BY workers.Id";

            MySqlCommand Command = new MySqlCommand(cmdText, Dbase.Connection());
            MySqlDataReader reader = Command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();

            }
            reader.Close();
            Dbase.CloseCon();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Db Dbase = new Db();
            MySqlCommand Command = new MySqlCommand("DELETE * FROM workers where Id='" + row+"'", Dbase.Connection());
            Dbase.OpenCon();
            Command.ExecuteNonQuery();
            Dbase.CloseCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WUpdateForm upd = new WUpdateForm(row);
            upd.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            int rw = e.RowIndex + 1;
            row = rw.ToString();
        }
    }
}
