using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSills2019_1_.Администрация
{
    public partial class Admin_menu : Form
    {
        public Admin_menu()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
        }
        // передвижение формы
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

        private void Admin_menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_Eixt_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите покинуть профиль Администратора системы?!", "Подтвердите", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dialog == DialogResult.OK)
            {
                ActiveForm.Hide();
                Home home = new Home();
                home.ShowDialog();
                Close();
            }
        }
        // грузим шестёрок для Марафона
        private void btn_OK_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Volunteer volunteer = new Volunteer();
            volunteer.ShowDialog();
            Close();
        }
    }
}
