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
    public partial class RegistrationForm : Form
    {

        DbConnect db = new DbConnect();
        public RegistrationForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void log_inButton_Click(object sender, EventArgs e)
        {

            var login_user = loginfield.Text;
            var password_user = passfield.Text;
            string querystring = $"insert into users(login_user, password_user) values('{loginfield}', '{passfield}')";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                AuthForm ath = new AuthForm();
                this.Hide();
                ath.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            db.CloseConnection();
        }

        private Boolean checkuser()
        {
            var loginuser = loginfield.Text;
            var passuser = passfield.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, login_user, password_user from users where login_user = '{loginuser}' and password_user = '{passuser}'";

            SqlCommand command = new SqlCommand(querystring, db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
