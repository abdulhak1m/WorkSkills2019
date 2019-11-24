using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSills2019_1_.Общее;
using WorldSills2019_1_.Общее.ConnectionStrings;

namespace WorldSills2019_1_.Бегун
{
    public partial class Edit_Profile_Runner : Form
    {
        public Edit_Profile_Runner()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
        }
        OpenFileDialog file = new OpenFileDialog();
        // метод загрузки картинки в PicureBox
        private void Open()
        {
            try
            {
                file.InitialDirectory = @"B:\Pinterest";
                file.Filter = "Image File (*.BMP;*.PNG;*.JPG;*.JPEG)| *.BMP;*.PNG;*.JPG;*.JPEG | All File (*.*)|*.*";
                file.FilterIndex = 2;
                if (file.ShowDialog() == DialogResult.OK)
                {
                    pc_image.Image = Image.FromFile(file.FileName);
                    pc_image.SizeMode = PictureBoxSizeMode.StretchImage;
                    pc_image.BorderStyle = BorderStyle.None;
                    lbl_pcname.Text = file.SafeFileName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        // панель передвижения формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
        // устанавливаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + "часов и " + totalTime.Minutes + " минут до старта Марафона!";

        }
        // запустить таймер
        private async void Edit_Profile_Runner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_maraphoneDataSet.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.my_maraphoneDataSet.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_maraphoneDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.my_maraphoneDataSet.Gender);
            timer1.Start();
            // при загрузке Формы, нам необходимо выгрузить данные из БД
            try
            {
                using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                {
                    await connection.OpenAsync();
                    // User.[Email], User.[Password]
                    SqlCommand command = new SqlCommand("SELECT [User].[FirstName], [User].[LastName], Country.[CountryName], Runner.[Gender], Runner.[DateOfBirth], Runner.[NamePic], Runner.[Picture] FROM [User], Country, Runner WHERE" +
                        "[User].Email = Runner.Email AND Runner.[CountryCode] = Country.[CountryCode] AND [User].Email = '" + Login.email + "'", connection);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt_username.Text = Login.email;
                            txt_name.Text = reader["FirstName"].ToString();
                            txt_surname.Text = reader["LastName"].ToString();
                            cmb_gender.SelectedItem = reader["Gender"].ToString();
                            cmb_Country.SelectedItem = reader["CountryName"].ToString();
                            dateTimePicker1.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                            lbl_pcname.Text = reader["NamePic"].ToString();
                            byte[] BinaryToImg = new byte[0];
                            BinaryToImg = (byte[])reader["Picture"];
                            MemoryStream ms = new MemoryStream(BinaryToImg);
                            this.pc_image.Image = Image.FromStream(ms);
                            pc_image.SizeMode = PictureBoxSizeMode.StretchImage;
                            pc_image.BorderStyle = BorderStyle.None;
                            ms.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // обращаемся к методу загрузки картинки
        private void btn_browse_Click(object sender, EventArgs e)
        {
            Open();
        }
        // переход в окно меню Бегуна
        private void btn_back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Runner_Menu menu = new Runner_Menu();
            menu.ShowDialog();
            Close();
        }

        private async void btn_done_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            byte[] a = new byte[0];
            try
            {
                pc_image.Image.Save(ms, pc_image.Image.RawFormat);
                a = ms.GetBuffer();
                ms.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Произошла ошибка при загрузке изображения '"+ex.Source+"'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                bool changePassword = false;
            try
            {
                if (txt_password.Text != "" && txt_cpassword.Text != "")
                    changePassword = true;
                if(txt_name.Text == "" || txt_surname.Text == "" || cmb_Country.Text == "" || cmb_gender.Text == "")
                    MessageBox.Show("Вы для прикола пытаетесь изменить свои данные в системе на пустые значения, если да, то " +
                        " это не возможно, а если нет, выключите компьютер и обратитесь к врачу.", "Ой, ошибка, явно клоун тупишь.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    bool digit = false;
                    bool spec = false;
                    bool lowchar = false;
                    bool pass = false;
                    if (changePassword)
                    {
                        for(int i = 0; i < txt_password.TextLength; i++)
                        {
                            if (char.IsDigit(txt_password.Text[i]))
                            {
                                digit = true;
                                break;
                            }
                        }
                        for(int i = 0; i < txt_password.TextLength; i++)
                        {
                            if (char.IsLower(txt_password.Text[i]))
                            {
                                lowchar = true;
                                break;
                            }
                        }
                        for(int i = 0; i < txt_password.TextLength; i++)
                        {
                            if(txt_password.Text[i] == '!' || txt_password.Text[i] == '@' || txt_password.Text[i] == '#' ||
                                txt_password.Text[i] == '$' || txt_password.Text[i] == '%' || txt_password.Text[i] == '^')
                            {
                                spec = true;
                                break;
                            }
                        }
                        if (txt_password.TextLength < 6 || !spec || !digit || !lowchar)
                            MessageBox.Show("Так, пароль имеет не вреный формат, по сооброжениям безопасности системы, мы, умные люди - " +
                                " разработчики данной системы, рекмендуем всем клоунам использовать пароль, где не менее 6-ти символов," +
                                " где как минимум должна быть одна цифра, одна буква нижнего регистра и одна из следующих символов - " +
                                " !,@,#,$,%,^. Пожалуйста составьте корректный пароль, не забудьте записать его, чтобы мне мозг не парить" +
                                " лишний раз, и повторите свою попытку! Удачи!", "Ой ошибка, Клоун, пароль некорректный!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            pass = true;
                        if (pass)
                        {
                            if(txt_password.Text != txt_cpassword.Text)
                                MessageBox.Show("Пароли не совпадают!", "Оповещение системы!");
                            else
                            {
                                changePassword = false;
                                pass = true;
                            }
                        }
                    }
                    if(changePassword == false)
                    {
                        DateTime dataofbirth = Convert.ToDateTime(dateTimePicker1.Value);
                        if(DateTime.Now.Year - dataofbirth.Year < 10)
                            MessageBox.Show("Внимание, на момент регистрации Клоуна (Бегуна), его возраст должно составлять не менее 10-ти лет!",
                                "Маленький ещё!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                            {
                                await connection.OpenAsync();
                                SqlCommand commandUser = new SqlCommand($"UPDATE [User] SET [FirstName] = '{txt_name.Text}', [LastName] = '{txt_surname.Text}' WHERE Email = '" + Login.email + "'", connection);
                                await commandUser.ExecuteNonQueryAsync();
                                SqlCommand commandRunner = new SqlCommand($"UPDATE [Runner] SET [Gender] = '{cmb_gender.SelectedItem}', [DateOfBirth] = '{Convert.ToDateTime(dateTimePicker1.Value)}', [CountryCode] = '{cmb_Country.SelectedItem}', [Picture] = '" + a + "' WHERE Email = '" + Login.email + "'", connection);
                                //SqlCommand commandRunner = new SqlCommand($"UPDATE Runner SET [Gender] = @g, [DateOfBirth] = @d, [CountryCode] = @c, [NamePic] = @n, [Picture] = @img WHERE Email = '" + Login.email + "'", connection);
                                //commandRunner.Parameters.AddWithValue("@g", cmb_gender.SelectedItem);
                                //commandRunner.Parameters.AddWithValue("@d", dateTimePicker1.Value);
                                //commandRunner.Parameters.AddWithValue("@c", cmb_Country.SelectedItem);
                                //commandRunner.Parameters.AddWithValue("@n", lbl_pcname.Text);
                                //commandRunner.Parameters.AddWithValue("@img", ToBinaryImg);

                                await commandRunner.ExecuteNonQueryAsync();
                                if (changePassword)
                                {
                                    SqlCommand commandPasswords = new SqlCommand("UPDATE [User] SET [Password] '" + txt_password.Text + "' WHERE Email = '" + Login.email + "'", connection);
                                    await commandPasswords.ExecuteNonQueryAsync();
                                }
                                DialogResult dialog = MessageBox.Show("Вы успешно изменили свои личные данные, хотите перейти в Меню?",
                                       "Сохранение новых данных прошло успешно!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (dialog == DialogResult.OK)
                                {
                                    ActiveForm.Hide();
                                    Runner_Menu menu = new Runner_Menu();
                                    menu.ShowDialog();
                                    Close();
                                }
                                else
                                    MessageBox.Show("Боюсь спросить, что ты ещё хочешь сделать своим профилем!",
                                        "Что-то ещё?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
        }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Sql '" + ex.Source + "'", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
    }
}
