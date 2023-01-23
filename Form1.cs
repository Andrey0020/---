using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo_exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "demo_examDataSet.products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.demo_examDataSet.products);

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            AddData add = new AddData();
            add.Show();
            this.Hide();

        }
    }
}
