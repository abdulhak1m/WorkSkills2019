using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSills2019_1_.Бегун
{
    public partial class Runner_Menu : Form
    {
        public Runner_Menu()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        // запускаем таймер
        private void Runner_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        // переход в окно регистрации на Марафон
        private void btn_registration_runner_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            MaraphoneRegistration registration = new MaraphoneRegistration();
            registration.ShowDialog();
            Close();
        }
        // переходим в окно редактирования профиля Клоуна
        private void btn_edit_profile_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Edit_Profile_Runner profile_Runner = new Edit_Profile_Runner();
            profile_Runner.ShowDialog();
            Close();
        }

        private void btn_Eixt_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите покинуть профиль Бегуна?", "Подтвердите",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                ActiveForm.Hide();
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
        }
    }
}
