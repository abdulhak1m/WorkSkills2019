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
            timer1.Start();
            // при загрузке Формы, нам необходимо выгрузить данные из БД
            try
            {
                using(SqlConnection connection = new SqlConnection(Connection.GetString()))
                {
                    await connection.OpenAsync();
                    // User.[Email], User.[Password]
                    SqlCommand command = new SqlCommand("SELECT User.[FirstName], User.[LastName], Country.[CountryName], Runner.[Gender], Runner.[DateOfBirth], Runner.[NamePic], Runner.[Picture] FROM User, Country, Runner WHERE" +
                        "User");
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

        private void btn_done_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
    }
}
