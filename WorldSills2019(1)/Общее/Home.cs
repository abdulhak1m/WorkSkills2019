using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldSills2019_1_.Бегун;
using WorldSills2019_1_.Общее;

namespace WorldSills2019_1_
{
    public partial class Home : Form
    {
        public Home()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // переход в окно авторизации пользователя Системы
        private void btn_Login_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void btn_Login_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btn_Login, "Авторизоваться");
        }
        // переходим в окно выбора типа бегуна
        private void btn_runner_Click_1(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Runner runner = new Runner();
            runner.ShowDialog();
            Close();
        }

        private void btn_sponsor_Click(object sender, EventArgs e)
        {

        }

        private void btn_info_Click(object sender, EventArgs e)
        {

        }
    }
}
