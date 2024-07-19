using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentsDB
{
    public partial class LogIn : Form
    {
        private User User;
        private SqlConnection SqlConnection;

        public bool IsClosed { get; set; }
        public bool IsLoggedIn { get; set; }

        public LogIn(SqlConnection sqlConnection)
        {
            InitializeComponent();
            SqlConnection = sqlConnection;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            User = new User(SqlConnection);
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Length > 0 && PasswordTextBox.Text.Length > 0)
            {
                if (User.GetUser(UserNameTextBox.Text, PasswordTextBox.Text))
                {
                    IsLoggedIn = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
        }

        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
        }
    }
}