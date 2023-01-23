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

namespace Demo_exam
{
    public partial class AuthForm : Form
    {
        DbConnect database = new DbConnect();

        public AuthForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm Rgf = new RegistrationForm();
            Rgf.Show();
            this.Hide();
        }

        private void sign_upButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text;
            String passwordUser = PasswordField.Text;

            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DbConnect db = new DbConnect();

            string querystring = $"SELECT login_user, password_user FROM users WHERE login_user = '{loginUser}' AND password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли");
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого пользователя нет!");
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void background_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
