using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSills2019_1_.Общее;

namespace WorldSills2019_1_.Бегун
{
    public partial class Runner : Form
    {
        public Runner()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
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
        // запускаем таймер
        private void Runner_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // переходим в окно авторизации
        private void btn_Login_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }
        // назад в стартовое окно 
        private void btn_back_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите покинуть окно авторизации?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
        }
        // переход в окно регистрации пользователя
        private void btn_new_runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            new_Runner new_runner = new new_Runner();
            new_runner.ShowDialog();
            Close();
        }
    }
}
