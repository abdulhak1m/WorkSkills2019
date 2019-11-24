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
    public partial class Volunteer : Form
    {
        public Volunteer()
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
        // запускаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";

        }
        // устанавливаем таймер
        private void Volunteer_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "Количество волонтёров в БД - " + this.volunteerBindingSource.Count.ToString();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "my_maraphoneDataSet.Volunteer". При необходимости она может быть перемещена или удалена.
            this.volunteerTableAdapter.Fill(this.my_maraphoneDataSet.Volunteer);
        }
        // грузим файл
        private void button1_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            DownloadCSV cSV = new DownloadCSV();
            cSV.ShowDialog();
            Close();
        }

        private void cmb_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            volunteerBindingSource.RemoveFilter();
            switch (cmb_filter.Text)
            {
                case "Имя":
                    dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                    break;
                case "Фамилия":
                    dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
                    break;
                case "Пол":
                    dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
                    break;
                case "Страна":
                    dataGridView1.Sort(dataGridView1.Columns[4], ListSortDirection.Ascending);
                    break;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Update();
            this.volunteerTableAdapter.Fill(this.my_maraphoneDataSet.Volunteer);
            label4.Text = "Количество волонтёров в БД - " + this.volunteerBindingSource.Count;
        }
    }
}
