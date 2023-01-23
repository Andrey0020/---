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
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void AddData_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = @"DATA Source=311-07-20;Initial Catalog=demo_exam;Integrated Security=True";

            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                    "INSERT INTO products(Наименование_продукции, Артикул, Минимальная_стоимость_для_агента,Тип_продукции,Количество_человек_для_производства,Номер_цеха_для_производства) VALUES (@Наименование_продукции,@Артикул,@Минимальная_стоимость_для_агента,@Тип_продукции,@Количество_человек_для_производства,@Номер_цеха_для_производства)"
                    );
                command.Connection = conn;
                command.Parameters.Add("Наименование_продукции", textBox1);
                command.Parameters.Add("Артикул", textBox2);
                command.Parameters.Add("Минимальная_стоимость_для_агента", textBox3);
                command.Parameters.Add("Тип_продукции", textBox4);
                command.Parameters.Add("Количество_человек_для_производства", textBox5);
                command.Parameters.Add("Номер_цеха_для_производства", textBox6);
                command.ExecuteNonQuery();
            }

            
        }
    }
}
