using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSills2019_1_.Общее.ConnectionStrings;

namespace WorldSills2019_1_.Бегун
{
    public partial class new_Runner : Form
    {
        public new_Runner()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
            PasswordBox(txt_cpassword, btn_cshow);
            PasswordBox(txt_password, btn_show);
            // текст полей
            #region TextBox
            txt_username.Text = "Введите логин";
            txt_username.ForeColor = Color.CornflowerBlue;

            txt_password.Text = "Введите пароль";
            txt_password.UseSystemPasswordChar = false;
            txt_password.ForeColor = Color.CornflowerBlue;

            txt_cpassword.Text = "Подтвердите пароль";
            txt_cpassword.UseSystemPasswordChar = false;
            txt_cpassword.ForeColor = Color.CornflowerBlue;

            txt_name.Text = "Введите имя";
            txt_name.ForeColor = Color.CornflowerBlue;

            txt_surname.Text = "Введите фамилию";
            txt_surname.ForeColor = Color.CornflowerBlue;

            //cmb_gender.SelectedIndex = 0;
            //cmb_Country.SelectedIndex = 0;

            #endregion

        }
        private void PasswordBox(TextBox text, Button button)
        {
            text.TextChanged += (s, e) => { text.UseSystemPasswordChar = true; };
            button.MouseDown += (s, e) => { text.UseSystemPasswordChar = false; };
            button.MouseUp += (s, e) =>
            {
                if (text.Text == "Введите пароль" || text.Text == "Подтвердите пароль")
                    text.UseSystemPasswordChar = false;
                else
                    text.UseSystemPasswordChar = true;
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
        
        // запускаем таймер
        private void new_Runner_Load(object sender, EventArgs e)
        {
            timer1.Start();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_maraphoneDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.my_maraphoneDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_maraphoneDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.my_maraphoneDataSet.Country);

        }
        // подсказки
        #region TextBox`s
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
            if (txt_password.Text == "Введите пароль")
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

        private void txt_cpassword_Enter(object sender, EventArgs e)
        {
            if (txt_cpassword.Text == "Подтвердите пароль")
            {
                txt_cpassword.Text = "";
                txt_cpassword.UseSystemPasswordChar = false;
                txt_cpassword.ForeColor = Color.Black;
            }
        }

        private void txt_cpassword_Leave(object sender, EventArgs e)
        {
            if (txt_cpassword.Text == "")
            {
                txt_cpassword.Text = "Подтвердите пароль";
                txt_cpassword.UseSystemPasswordChar = false;
                txt_cpassword.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            if (txt_name.Text == "Введите имя")
            {
                txt_name.Text = "";
                txt_name.ForeColor = Color.Black;
            }
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                txt_name.Text = "Введите имя";
                txt_name.ForeColor = Color.CornflowerBlue;
            }
        }

        private void txt_surname_Enter(object sender, EventArgs e)
        {
            if (txt_surname.Text == "Введите фамилию")
            {
                txt_surname.Text = "";
                txt_surname.ForeColor = Color.Black;
            }
        }

        private void txt_surname_Leave(object sender, EventArgs e)
        {
            if (txt_surname.Text == "")
            {
                txt_surname.Text = "Введите фамилию";
                txt_surname.ForeColor = Color.CornflowerBlue;
            }
        }
        #endregion
        // покинуть окно регистрации пользователя в Системе
        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действивтельно хотите покинуть окно регистрации Бегуна?",
                "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
        }
        // подсказка пользователю
        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_back, "<-назад");
        }
        // регистрация нового пользователя в Системе
        private async void btn_done_Click(object sender, EventArgs e)
        {
            // разбиваем фотографию на бинарный формат
            MemoryStream ms = new MemoryStream();
            pc_image.Image.Save(ms, pc_image.Image.RawFormat);
            byte[] a = ms.GetBuffer();
            ms.Close();
            try
            {
                Regex emailRegex = new Regex(@"\w{2,10}@\w{2,10}.\w{2,10}");
                Match emailMatch = emailRegex.Match(txt_username.Text);
                if (emailMatch.Value == "")
                    MessageBox.Show("Неккоректный фомат email, пожалуйста повторите попытки", "Оповещение система!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                else
                {
                    bool digit = false;
                    bool spec = false;
                    bool lowChar = false;
                    for (int i = 0; i < txt_cpassword.TextLength; i++)
                    {
                        if (char.IsDigit(txt_cpassword.Text[i]))
                        {
                            digit = true;
                            break;
                        }
                    }
                    for (int i = 0; i < txt_cpassword.TextLength; i++)
                    {
                        if (char.IsLower(txt_cpassword.Text[i]))
                        {
                            lowChar = true;
                            break;
                        }
                    }
                    for (int i = 0; i < txt_cpassword.TextLength; i++)
                    {
                        if (txt_cpassword.Text[i] == '!' || txt_cpassword.Text[i] == '@' || txt_cpassword.Text[i] == '#' || txt_cpassword.Text[i] == '$' ||
                            txt_cpassword.Text[i] == '%' || txt_cpassword.Text[i] == '^' || txt_cpassword.Text[i] == '&')
                        {
                            spec = true;
                            break;
                        }
                    }
                    if (txt_cpassword.TextLength < 6 || !spec || !digit || !lowChar)
                        MessageBox.Show("Неккоректный формат пароля! Длина пароля не должно составлять менее шести символов из которых, как минимум должна быть одна цифра," +
                            " одна буква нижнего регистра и одна из следующих символов !,@,#,$,%,^,&", "Некорректный пароль", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    DateTime dataOfBirth = Convert.ToDateTime(dateTimePicker1.Value);
                    if(DateTime.Now.Year - dataOfBirth.Year < 10)
                        MessageBox.Show("Возраст Бегуна на момент регистрации не должно составлять меньше 10-ти лет!", 
                            "Оповещение системы!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    else
                    {
                        using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand("INSERT INTO [User] VALUES (@e,@p,@n,@s,@r)", connection);
                            command.Parameters.AddWithValue("@e", txt_username.Text);
                            command.Parameters.AddWithValue("@p", txt_password.Text);
                            command.Parameters.AddWithValue("@n", txt_name.Text);
                            command.Parameters.AddWithValue("@s", txt_surname.Text);
                            command.Parameters.AddWithValue("@r", 'R');
                            await command.ExecuteNonQueryAsync();

                            SqlCommand command2 = new SqlCommand("INSERT INTO Runner VALUES (@e,@g,@n,@img,@date,@code)", connection);
                            command2.Parameters.AddWithValue("@e", txt_username.Text);
                            command2.Parameters.AddWithValue("@g", cmb_gender.Text);
                            command2.Parameters.AddWithValue("@n", lbl_pcname.Text);
                            command2.Parameters.AddWithValue("@img", a);
                            command2.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                            command2.Parameters.AddWithValue("@code", cmb_Country.SelectedValue);
                            await command2.ExecuteNonQueryAsync();
                            MessageBox.Show("Данные о вас успешно сохранены в системе!", "Поздравляю клоун, данные сохранены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MaraphoneRegWindow();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        OpenFileDialog file = new OpenFileDialog();
        // метод загрузки картинки в PicureBox
        private void Open()
        {
            try
            {
                file.InitialDirectory = @"C:\Users\admin\Pictures\Saved Pictures";
                file.Filter = "Image File (*.BMP;*.PNG;*.JPG;*.JPEG)| *.BMP;*.PNG;*.JPG;*.JPEG | All File (*.*)|*.*";
                file.FilterIndex = 2;
                if(file.ShowDialog() == DialogResult.OK)
                {
                    pc_image.Image = Image.FromFile(file.FileName);
                    pc_image.SizeMode = PictureBoxSizeMode.StretchImage;
                    pc_image.BorderStyle = BorderStyle.None;
                    lbl_pcname.Text = file.SafeFileName.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        // устанавливаем таймер
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        // в случаи успешной регистрации, срабатывет этот метод, который перекинет пользователя в форму регистрации на марафон
        private void MaraphoneRegWindow()
        {
            ActiveForm.Hide();
            MaraphoneRegistration registration = new MaraphoneRegistration();
            registration.ShowDialog();
            Close();
        }
        private void btn_browse_Click(object sender, EventArgs e)
        {
            Open();
        }
    }
}
