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
    public partial class MaraphoneRegistration : Form
    {
        public MaraphoneRegistration()
        {
            InitializeComponent();
            // закрыть окно 
            btn_Close.Click += (s, e) => { Close(); };
            // скрыть окно
            btn_minimized.Click += (s, e) => { WindowState = FormWindowState.Minimized; };
            // передвижение формы
            FormMovement();
        }
        public int value;
        // устанавливаем таймер
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime maraphoneSkills = new DateTime(2019, 12, 12, 6, 0, 0);
            TimeSpan totalTime = maraphoneSkills - DateTime.Now;
            lbl_timer.Text = totalTime.Days + " дней " + totalTime.Hours + " часов и " + totalTime.Minutes + " минут до старта Марафона!";
        }
        // панель передвижения формы
        private void FormMovement()
        {
            int move = 0, x = 0, y = 0;
            topPanel.MouseDown += (s, e) => { move = 1; x = e.X; y = e.Y; };
            topPanel.MouseMove += (s, e) => { if (move == 1) SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y); };
            topPanel.MouseUp += (s, e) => { move = 0; };
        }
      
        // покинуть окно регистрации на марафон
        private void btn_back_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Runner_Menu runner_Menu = new Runner_Menu();
            runner_Menu.ShowDialog();
            Close();
        }

        // запускаем таймер
        private void MaraphoneRegistration_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private async void btn_Registration_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                MessageBox.Show("Пожалуйста, выберите один из представленных марафонов",
                    "Выбери что-нибудь клоун!");
            else
            {
                using (SqlConnection connection = new SqlConnection(Connection.GetString()))
                {
                    await connection.OpenAsync();
                    SqlCommand command = new SqlCommand("INSERT INTO Offers VALUES (@N, @A)", connection);
                    command.Parameters.AddWithValue("@N", comboBox1.Text);
                    command.Parameters.AddWithValue("@A", int.Parse(lbl_Num.Text));
                    await command.ExecuteNonQueryAsync();
                    MessageBox.Show("Test");
                }
            }
        }

        // CHECKBOX
        #region CheckBox
        // 42 km
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // если у нас выбран первый варинт, остальные варианты не могут быть выбраны
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(lbl_Num.Text);
                value += (145);
                lbl_Num.Text = value.ToString();
            }
            else
                lbl_Num.Text = (value - 145).ToString();
        }
        // 21 km
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                value = Convert.ToInt32(lbl_Num.Text);
                value += (75);
                lbl_Num.Text = value.ToString();
            }
            else
                lbl_Num.Text = (value - 75).ToString();
        }
        //5 km
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox2.Checked = false;
                checkBox1.Checked = false;
                value = Convert.ToInt32(lbl_Num.Text);
                value += (20);
                lbl_Num.Text = value.ToString();
            }
            else
                lbl_Num.Text = (value - 20).ToString();
        }
        #endregion

        // RADIOBUTTON`S
        #region RadioButton
        // $0
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                value = Convert.ToInt32(lbl_Num.Text);
                value += 0;
                lbl_Num.Text = value.ToString();
            }
        }
        // $20
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                value = Convert.ToInt32(lbl_Num.Text);
                value += 20;
                lbl_Num.Text = value.ToString();
            }
            else
                lbl_Num.Text = (value - 20).ToString();
        }
        // $45
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                value = Convert.ToInt32(lbl_Num.Text);
                value += 45;
                lbl_Num.Text = value.ToString();
            }
            else
                lbl_Num.Text = (value - 45).ToString();
        }
        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbl_Num.Text) >= 0)
            {
                value = Convert.ToInt32(lbl_Num.Text);
                value = Convert.ToInt32(numericUpDown1.Value);
                lbl_Num.Text = value.ToString();
            }
        }
    }
}
