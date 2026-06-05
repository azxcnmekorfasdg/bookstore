using BookStore.Models;
using BookStore.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyDesign();
        }

        private void ApplyDesign()
        {
            this.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);

            this.BackColor = Color.White;
            _loginButton.BackColor = Color.FromArgb(84, 111, 148);
            _guestButton.BackColor = Color.FromArgb(84, 111, 148);
            _loginButton.ForeColor = Color.White;
            _guestButton.ForeColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = _loginBox.Text.Trim();
            string password = _passwordBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string sql = @"
                    SELECT u.UserId, u.Login, u.FullName, u.RoleId, r.RoleName 
                    FROM Users u 
                    INNER JOIN Roles r ON u.RoleId = r.RoleId 
                    WHERE u.Login = @login AND u.Password = @password;";

                DataTable table = DatabaseHelper.ExecuteQuery(sql,
                    new SqlParameter("@login", login),
                    new SqlParameter("@password", password));

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = table.Rows[0];
                UserInfo user = new UserInfo
                {
                    UserId = (int)row["UserId"],
                    Login = row["Login"].ToString(),
                    FullName = row["FullName"].ToString(),
                    RoleId = (int)row["RoleId"],
                    RoleName = row["RoleName"].ToString()
                };
                AppSession.CurrentUser = user;

                OpenProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка базы данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            AppSession.Clear();
            OpenProductList();
        }

        private void OpenProductList()
        {
            Hide();
            ProductListForm form = new ProductListForm();
            form.ShowDialog();
            _loginBox.Text = "";
            _passwordBox.Text = "";
            Show();
        }
    }
}