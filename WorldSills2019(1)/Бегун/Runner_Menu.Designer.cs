namespace WorldSills2019_1_.Бегун
{
    partial class Runner_Menu
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_edit_profile = new System.Windows.Forms.Button();
            this.btn_registration_runner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Contact = new System.Windows.Forms.Button();
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
            this.topPanel.Size = new System.Drawing.Size(559, 25);
            this.topPanel.TabIndex = 7;
            // 
            // btn_minimized
            // 
            this.btn_minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.ForeColor = System.Drawing.Color.White;
            this.btn_minimized.Image = global::WorldSills2019_1_.Properties.Resources.icons8_m5acos_minimize_16;
            this.btn_minimized.Location = new System.Drawing.Point(509, 0);
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
            this.btn_Close.Location = new System.Drawing.Point(534, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_timer.Location = new System.Drawing.Point(0, 374);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(559, 50);
            this.lbl_timer.TabIndex = 9;
            this.lbl_timer.Text = "Timer";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit_profile
            // 
            this.btn_edit_profile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit_profile.FlatAppearance.BorderSize = 0;
            this.btn_edit_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_profile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit_profile.ForeColor = System.Drawing.Color.White;
            this.btn_edit_profile.Location = new System.Drawing.Point(111, 180);
            this.btn_edit_profile.Name = "btn_edit_profile";
            this.btn_edit_profile.Size = new System.Drawing.Size(337, 65);
            this.btn_edit_profile.TabIndex = 10;
            this.btn_edit_profile.Text = "Редактировать профиль";
            this.btn_edit_profile.UseVisualStyleBackColor = false;
            // 
            // btn_registration_runner
            // 
            this.btn_registration_runner.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_registration_runner.FlatAppearance.BorderSize = 0;
            this.btn_registration_runner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registration_runner.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_registration_runner.ForeColor = System.Drawing.Color.White;
            this.btn_registration_runner.Location = new System.Drawing.Point(111, 109);
            this.btn_registration_runner.Name = "btn_registration_runner";
            this.btn_registration_runner.Size = new System.Drawing.Size(337, 65);
            this.btn_registration_runner.TabIndex = 11;
            this.btn_registration_runner.Text = "Регистрация на марафон";
            this.btn_registration_runner.UseVisualStyleBackColor = false;
            this.btn_registration_runner.Click += new System.EventHandler(this.btn_registration_runner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(181, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 33);
            this.label1.TabIndex = 22;
            this.label1.Text = "Меню Бегуна";
            // 
            // btn_Contact
            // 
            this.btn_Contact.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Contact.FlatAppearance.BorderSize = 0;
            this.btn_Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contact.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Contact.ForeColor = System.Drawing.Color.White;
            this.btn_Contact.Location = new System.Drawing.Point(111, 251);
            this.btn_Contact.Name = "btn_Contact";
            this.btn_Contact.Size = new System.Drawing.Size(337, 65);
            this.btn_Contact.TabIndex = 10;
            this.btn_Contact.Text = "Контакты";
            this.btn_Contact.UseVisualStyleBackColor = false;
            // 
            // Runner_Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Contact);
            this.Controls.Add(this.btn_edit_profile);
            this.Controls.Add(this.btn_registration_runner);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Runner_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Runner_Menu";
            this.Load += new System.EventHandler(this.Runner_Menu_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_edit_profile;
        private System.Windows.Forms.Button btn_registration_runner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Contact;
    }
}