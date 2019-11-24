using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSills2019_1_.Администрация;
using WorldSills2019_1_.Бегун;
using WorldSills2019_1_.Общее.ConnectionStrings;

namespace WorldSills2019_1_.Общее
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
            PasswordBox();
            // текст полей
            #region TextBox
            txt_username.Text = "Введите логин";
            txt_username.ForeColor = Color.CornflowerBlue;

            txt_password.Text = "Введите пароль";
            txt_password.UseSystemPasswordChar = false;
            txt_password.ForeColor = Color.CornflowerBlue;
            #endregion
        }
        public static string email;
        // приватный ввод пароля
        private void PasswordBox()
        {
            txt_password.TextChanged += (s, e) => { txt_password.UseSystemPasswordChar = true; };
            btn_show.MouseDown += (s, e) => { txt_password.UseSystemPasswordChar = false; };
            btn_show.MouseUp += (s, e) => 
            {
                if (txt_password.Text == "Введите пароль")
                    txt_password.UseSystemPasswordChar = false;
                else
                    txt_password.UseSystemPasswordChar = true;
            };
        }
        // панель передвижения формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + "часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        // переход в стартовое окно
        private void btn_back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Home home = new Home();
            home.ShowDialog();
            Close();
        }
        // подсказка пользователю
        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Login, "Авторизваться");
        }
        // подсказка пользователю
        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_back, "<-назад");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // пользовательские подсказки
        // клиентская область программы
        #region ClientAreal
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Введите логин")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Введите логин";
                txt_username.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if(txt_password.Text == "Введите пароль")
            {
                txt_password.Text = "";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.Black;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Введите пароль";
                txt_password.UseSystemPasswordChar = false;
                txt_password.ForeColor = Color.CornflowerBlue;
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }
        #endregion
        // авторизация
        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.GetString()))
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE Email = '" + txt_username.Text.Trim() + "' and [Password] = '" + txt_password.Text.Trim() + "'", connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Пользователь с таким логином и паролем не найден в системе! " +
                                "Удостоверьтесь в корректности введённых данных.", "Такого клона нет в Базе Данных", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                email = reader["Email"].ToString();
                                if (reader["RoleId"].ToString() == "R")
                                {
                                    ActiveForm.Hide();
                                    Runner_Menu menu = new Runner_Menu();
                                    menu.ShowDialog();
                                    Close();
                                }
                                if(reader["RoleId"].ToString() == "A")
                                {
                                    ActiveForm.Hide();
                                    Admin_menu admin = new Admin_menu();
                                    admin.ShowDialog();
                                    Close();
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
