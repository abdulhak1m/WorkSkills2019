﻿namespace WorldSills2019_1_.Бегун
{
    partial class new_Runner
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_cpassword = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.pc_image = new System.Windows.Forms.PictureBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_pcname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_cshow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dbMaraphoneDataSet = new WorldSills2019_1_.dbMaraphoneDataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new WorldSills2019_1_.dbMaraphoneDataSetTableAdapters.CountryTableAdapter();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaraphoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
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
            this.topPanel.Size = new System.Drawing.Size(800, 25);
            this.topPanel.TabIndex = 5;
            // 
            // btn_minimized
            // 
            this.btn_minimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimized.FlatAppearance.BorderSize = 0;
            this.btn_minimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimized.ForeColor = System.Drawing.Color.White;
            this.btn_minimized.Image = global::WorldSills2019_1_.Properties.Resources.icons8_m5acos_minimize_16;
            this.btn_minimized.Location = new System.Drawing.Point(750, 0);
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
            this.btn_Close.Location = new System.Drawing.Point(775, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(25, 25);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "MaraphoneSkills 2019 Moscow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_timer
            // 
            this.lbl_timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_timer.Location = new System.Drawing.Point(0, 456);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(800, 50);
            this.lbl_timer.TabIndex = 7;
            this.lbl_timer.Text = "Timer";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_username.Location = new System.Drawing.Point(44, 98);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(293, 16);
            this.txt_username.TabIndex = 9;
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Location = new System.Drawing.Point(44, 139);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(293, 16);
            this.txt_password.TabIndex = 10;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(44, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 5);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(44, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 5);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(44, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 5);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Location = new System.Drawing.Point(44, 239);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 5);
            this.panel4.TabIndex = 11;
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Location = new System.Drawing.Point(44, 222);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(293, 16);
            this.txt_name.TabIndex = 10;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // txt_cpassword
            // 
            this.txt_cpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpassword.Location = new System.Drawing.Point(44, 181);
            this.txt_cpassword.Name = "txt_cpassword";
            this.txt_cpassword.Size = new System.Drawing.Size(293, 16);
            this.txt_cpassword.TabIndex = 9;
            this.txt_cpassword.Enter += new System.EventHandler(this.txt_cpassword_Enter);
            this.txt_cpassword.Leave += new System.EventHandler(this.txt_cpassword_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(44, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 5);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(44, 331);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(293, 5);
            this.panel6.TabIndex = 11;
            // 
            // txt_surname
            // 
            this.txt_surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_surname.Location = new System.Drawing.Point(44, 262);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(293, 16);
            this.txt_surname.TabIndex = 9;
            this.txt_surname.Enter += new System.EventHandler(this.txt_surname_Enter);
            this.txt_surname.Leave += new System.EventHandler(this.txt_surname_Leave);
            // 
            // cmb_gender
            // 
            this.cmb_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_gender.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Выберите пол",
            "Мужской",
            "Женский",
            "Нариман"});
            this.cmb_gender.Location = new System.Drawing.Point(44, 305);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(293, 25);
            this.cmb_gender.TabIndex = 13;
            // 
            // pc_image
            // 
            this.pc_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pc_image.Location = new System.Drawing.Point(491, 115);
            this.pc_image.Name = "pc_image";
            this.pc_image.Size = new System.Drawing.Size(230, 146);
            this.pc_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_image.TabIndex = 14;
            this.pc_image.TabStop = false;
            // 
            // btn_browse
            // 
            this.btn_browse.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_browse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_browse.ForeColor = System.Drawing.Color.White;
            this.btn_browse.Location = new System.Drawing.Point(491, 279);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(230, 39);
            this.btn_browse.TabIndex = 15;
            this.btn_browse.Text = "Обзор...";
            this.btn_browse.UseVisualStyleBackColor = false;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_pcname
            // 
            this.lbl_pcname.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_pcname.Location = new System.Drawing.Point(488, 78);
            this.lbl_pcname.Name = "lbl_pcname";
            this.lbl_pcname.Size = new System.Drawing.Size(233, 36);
            this.lbl_pcname.TabIndex = 16;
            this.lbl_pcname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(491, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(230, 23);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(488, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Год Рождения";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Location = new System.Drawing.Point(483, 438);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 5);
            this.panel7.TabIndex = 11;
            // 
            // cmb_Country
            // 
            this.cmb_Country.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.countryBindingSource, "CountryName", true));
            this.cmb_Country.DataSource = this.countryBindingSource;
            this.cmb_Country.DisplayMember = "CountryName";
            this.cmb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Country.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(483, 412);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(238, 25);
            this.cmb_Country.TabIndex = 13;
            this.cmb_Country.ValueMember = "CountryName";
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_done.FlatAppearance.BorderSize = 0;
            this.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_done.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_done.ForeColor = System.Drawing.Color.White;
            this.btn_done.Location = new System.Drawing.Point(185, 374);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(152, 39);
            this.btn_done.TabIndex = 15;
            this.btn_done.Text = "Готово";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_back
            // 
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = global::WorldSills2019_1_.Properties.Resources.icons8_arrow_pointing_left_32;
            this.btn_back.Location = new System.Drawing.Point(44, 375);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(61, 37);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseEnter += new System.EventHandler(this.btn_back_MouseEnter);
            // 
            // btn_show
            // 
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.Image = global::WorldSills2019_1_.Properties.Resources.icons8_visible_filled_16;
            this.btn_show.Location = new System.Drawing.Point(343, 133);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(25, 25);
            this.btn_show.TabIndex = 20;
            this.btn_show.UseVisualStyleBackColor = false;
            // 
            // btn_cshow
            // 
            this.btn_cshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cshow.FlatAppearance.BorderSize = 0;
            this.btn_cshow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cshow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_cshow.ForeColor = System.Drawing.Color.White;
            this.btn_cshow.Image = global::WorldSills2019_1_.Properties.Resources.icons8_visible_filled_16;
            this.btn_cshow.Location = new System.Drawing.Point(343, 175);
            this.btn_cshow.Name = "btn_cshow";
            this.btn_cshow.Size = new System.Drawing.Size(25, 25);
            this.btn_cshow.TabIndex = 20;
            this.btn_cshow.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // dbMaraphoneDataSet
            // 
            this.dbMaraphoneDataSet.DataSetName = "dbMaraphoneDataSet";
            this.dbMaraphoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.dbMaraphoneDataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // new_Runner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_cpassword);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_Country);
            this.Controls.Add(this.btn_cshow);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_pcname);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.pc_image);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "new_Runner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.new_Runner_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMaraphoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_cpassword;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.PictureBox pc_image;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lbl_pcname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_cshow;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Timer timer1;
        private dbMaraphoneDataSet dbMaraphoneDataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private dbMaraphoneDataSetTableAdapters.CountryTableAdapter countryTableAdapter;
    }
}