using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompaniesWorkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    Workers FormWorkers = new Workers();
      Companies FormCompanies = new Companies();
        private void Companies_Click(object sender, EventArgs e)
        {
            FormCompanies.Show();
           
            this.Hide();
        }

        private void Workers_Click(object sender, EventArgs e)
        {
            FormWorkers.Show();
            this.Hide();
        }
    }
}
