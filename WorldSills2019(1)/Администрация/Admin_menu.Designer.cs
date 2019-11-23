namespace WorldSills2019_1_.Администрация
{
    partial class Admin_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.topPanel.Controls.Add(this.btn_minimized);
            this.topPanel.Controls.Add(this.btn_Close);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(625, 25);
            this.topPanel.TabIndex = 8;
            // 
            // btn_minimized
            // 
            this.btn_minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.ForeColor = System.Drawing.Color.White;
            this.btn_minimized.Image = global::WorldSills2019_1_.Properties.Resources.icons8_m5acos_minimize_16;
            this.btn_minimized.Location = new System.Drawing.Point(575, 0);
            this.btn_minimized.Name = "btn_minimized";
            this.btn_minimized.Size = new System.Drawing.Size(25, 25);
            this.btn_minimized.TabIndex = 2;
            this.btn_minimized.UseVisualStyleBackColor = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Image = global::WorldSills2019_1_.Properties.Resources.icons8_shutdown_16;
            this.btn_Close.Location = new System.Drawing.Point(600, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // lbl_timer
            // 
            this.lbl_timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_timer.Location = new System.Drawing.Point(0, 320);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(625, 50);
            this.lbl_timer.TabIndex = 10;
            this.lbl_timer.Text = "Timer";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = global::WorldSills2019_1_.Properties.Resources.icons8_arrow_pointing_left_32;
            this.btn_back.Location = new System.Drawing.Point(12, 31);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(61, 37);
            this.btn_back.TabIndex = 11;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(94, 108);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(437, 74);
            this.btn_OK.TabIndex = 22;
            this.btn_OK.Text = "Волонтёры";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(94, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(437, 74);
            this.button1.TabIndex = 22;
            this.button1.Text = "Пользователи";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Admin_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_menu_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button button1;
    }
}