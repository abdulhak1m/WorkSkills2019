namespace WorldSills2019_1_.Администрация
{
    partial class Volunteer
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
            this.lbl_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_filter = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.my_maraphoneDataSet = new WorldSills2019_1_.my_maraphoneDataSet();
            this.volunteerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.volunteerTableAdapter = new WorldSills2019_1_.my_maraphoneDataSetTableAdapters.VolunteerTableAdapter();
            this.volunteerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_minimized = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_maraphoneDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).BeginInit();
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
            this.topPanel.TabIndex = 9;
            // 
            // lbl_timer
            // 
            this.lbl_timer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_timer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_timer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_timer.Location = new System.Drawing.Point(0, 400);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(800, 50);
            this.lbl_timer.TabIndex = 11;
            this.lbl_timer.Text = "Timer";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(214, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Управление Волонтёрами";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(93, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сортировка и фльтрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Сортировать по:";
            // 
            // cmb_filter
            // 
            this.cmb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_filter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cmb_filter.FormattingEnabled = true;
            this.cmb_filter.Items.AddRange(new object[] {
            "Имя",
            "Фамилия",
            "Пол",
            "Страна"});
            this.cmb_filter.Location = new System.Drawing.Point(132, 109);
            this.cmb_filter.Name = "cmb_filter";
            this.cmb_filter.Size = new System.Drawing.Size(139, 25);
            this.cmb_filter.TabIndex = 15;
            this.cmb_filter.SelectedIndexChanged += new System.EventHandler(this.cmb_filter_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(132, 135);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(139, 5);
            this.panel6.TabIndex = 14;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Refresh.FlatAppearance.BorderSize = 0;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(15, 209);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(128, 33);
            this.btn_Refresh.TabIndex = 23;
            this.btn_Refresh.Text = "Обновить";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(540, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 33);
            this.button1.TabIndex = 23;
            this.button1.Text = "Загрузка волонтёров";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.volunteerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.volunteerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(172, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 24;
            // 
            // my_maraphoneDataSet
            // 
            this.my_maraphoneDataSet.DataSetName = "my_maraphoneDataSet";
            this.my_maraphoneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // volunteerBindingSource
            // 
            this.volunteerBindingSource.DataMember = "Volunteer";
            this.volunteerBindingSource.DataSource = this.my_maraphoneDataSet;
            // 
            // volunteerTableAdapter
            // 
            this.volunteerTableAdapter.ClearBeforeFill = true;
            // 
            // volunteerIdDataGridViewTextBoxColumn
            // 
            this.volunteerIdDataGridViewTextBoxColumn.DataPropertyName = "VolunteerId";
            this.volunteerIdDataGridViewTextBoxColumn.HeaderText = "VolunteerId";
            this.volunteerIdDataGridViewTextBoxColumn.Name = "volunteerIdDataGridViewTextBoxColumn";
            this.volunteerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(169, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество волонтёров в БД - ";
            // 
            // Volunteer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_filter);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Volunteer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volunteer";
            this.Load += new System.EventHandler(this.Volunteer_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.my_maraphoneDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volunteerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btn_minimized;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_filter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private my_maraphoneDataSet my_maraphoneDataSet;
        private System.Windows.Forms.BindingSource volunteerBindingSource;
        private my_maraphoneDataSetTableAdapters.VolunteerTableAdapter volunteerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn volunteerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}