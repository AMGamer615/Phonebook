namespace Phonebook
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Search_Box = new GroupBox();
            Search_TextBox = new Resources.RoundedTextBox(components);
            menuStrip1 = new MenuStrip();
            AddPeople_ToolStrip = new ToolStripMenuItem();
            AddUser_ToolStrip = new ToolStripMenuItem();
            Update_ToolStrip = new ToolStripMenuItem();
            ChangePassword_ToolStrip = new ToolStripMenuItem();
            Remove_Button = new Resources.RoundedButton(components);
            List_Box = new GroupBox();
            People_DataGridView = new DataGridView();
            People_Id = new DataGridViewTextBoxColumn();
            People_Name = new DataGridViewTextBoxColumn();
            People_LastName = new DataGridViewTextBoxColumn();
            People_Sex = new DataGridViewTextBoxColumn();
            People_BirthDay = new DataGridViewTextBoxColumn();
            People_PhoneNumber = new DataGridViewTextBoxColumn();
            People_Email = new DataGridViewTextBoxColumn();
            Edit_Button = new Resources.RoundedButton(components);
            Information_TextBox = new Resources.RoundedTextBox(components);
            Search_Box.SuspendLayout();
            menuStrip1.SuspendLayout();
            List_Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)People_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Search_Box
            // 
            Search_Box.BackColor = SystemColors.ControlLight;
            Search_Box.Controls.Add(Search_TextBox);
            Search_Box.Location = new Point(12, 27);
            Search_Box.Name = "Search_Box";
            Search_Box.RightToLeft = RightToLeft.Yes;
            Search_Box.Size = new Size(696, 68);
            Search_Box.TabIndex = 0;
            Search_Box.TabStop = false;
            Search_Box.Text = "جستجو";
            // 
            // Search_TextBox
            // 
            Search_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Search_TextBox.Location = new Point(373, 22);
            Search_TextBox.Name = "Search_TextBox";
            Search_TextBox.PlaceholderText = "جستجو";
            Search_TextBox.Round = 25;
            Search_TextBox.Size = new Size(242, 29);
            Search_TextBox.TabIndex = 0;
            Search_TextBox.TextAlign = HorizontalAlignment.Center;
            Search_TextBox.TextChanged += Search_TextBox_TextChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Menu;
            menuStrip1.Items.AddRange(new ToolStripItem[] { AddPeople_ToolStrip, AddUser_ToolStrip, Update_ToolStrip, ChangePassword_ToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(720, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // AddPeople_ToolStrip
            // 
            AddPeople_ToolStrip.Name = "AddPeople_ToolStrip";
            AddPeople_ToolStrip.Size = new Size(114, 20);
            AddPeople_ToolStrip.Text = "افزودن شخص جدید";
            AddPeople_ToolStrip.Click += AddPeople_ToolStrip_Click;
            // 
            // AddUser_ToolStrip
            // 
            AddUser_ToolStrip.Name = "AddUser_ToolStrip";
            AddUser_ToolStrip.Size = new Size(104, 20);
            AddUser_ToolStrip.Text = "افزودن کاربر جدید";
            AddUser_ToolStrip.Click += AddUser_ToolStrip_Click;
            // 
            // Update_ToolStrip
            // 
            Update_ToolStrip.Name = "Update_ToolStrip";
            Update_ToolStrip.Size = new Size(68, 20);
            Update_ToolStrip.Text = "بروزرسانی";
            Update_ToolStrip.Click += Update_ToolStrip_Click;
            // 
            // ChangePassword_ToolStrip
            // 
            ChangePassword_ToolStrip.Name = "ChangePassword_ToolStrip";
            ChangePassword_ToolStrip.Size = new Size(87, 20);
            ChangePassword_ToolStrip.Text = "تغییر رمز عبور";
            ChangePassword_ToolStrip.Click += ChangePassword_ToolStrip_Click;
            // 
            // Remove_Button
            // 
            Remove_Button.BackColor = SystemColors.ScrollBar;
            Remove_Button.ForeColor = SystemColors.HotTrack;
            Remove_Button.Location = new Point(528, 403);
            Remove_Button.Name = "Remove_Button";
            Remove_Button.Round = 25;
            Remove_Button.Size = new Size(87, 37);
            Remove_Button.TabIndex = 1;
            Remove_Button.Text = "حذف";
            Remove_Button.UseVisualStyleBackColor = false;
            Remove_Button.Click += Remove_Button_Click;
            // 
            // List_Box
            // 
            List_Box.Controls.Add(People_DataGridView);
            List_Box.Location = new Point(12, 101);
            List_Box.Name = "List_Box";
            List_Box.RightToLeft = RightToLeft.Yes;
            List_Box.Size = new Size(696, 298);
            List_Box.TabIndex = 6;
            List_Box.TabStop = false;
            List_Box.Text = "لیست";
            // 
            // People_DataGridView
            // 
            People_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            People_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            People_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            People_DataGridView.Columns.AddRange(new DataGridViewColumn[] { People_Id, People_Name, People_LastName, People_Sex, People_BirthDay, People_PhoneNumber, People_Email });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            People_DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            People_DataGridView.Location = new Point(6, 22);
            People_DataGridView.Name = "People_DataGridView";
            People_DataGridView.ReadOnly = true;
            People_DataGridView.RowTemplate.Height = 25;
            People_DataGridView.Size = new Size(684, 270);
            People_DataGridView.TabIndex = 0;
            // 
            // People_Id
            // 
            People_Id.DataPropertyName = "PeopleId";
            People_Id.HeaderText = "Id";
            People_Id.Name = "People_Id";
            People_Id.ReadOnly = true;
            People_Id.Visible = false;
            // 
            // People_Name
            // 
            People_Name.DataPropertyName = "Name";
            People_Name.HeaderText = "نام";
            People_Name.Name = "People_Name";
            People_Name.ReadOnly = true;
            // 
            // People_LastName
            // 
            People_LastName.DataPropertyName = "LastName";
            People_LastName.HeaderText = "نام خانوادگی";
            People_LastName.Name = "People_LastName";
            People_LastName.ReadOnly = true;
            // 
            // People_Sex
            // 
            People_Sex.DataPropertyName = "Sex";
            People_Sex.HeaderText = "جنسیت";
            People_Sex.Name = "People_Sex";
            People_Sex.ReadOnly = true;
            // 
            // People_BirthDay
            // 
            People_BirthDay.DataPropertyName = "BirthDay";
            People_BirthDay.HeaderText = "تاریخ تولد";
            People_BirthDay.Name = "People_BirthDay";
            People_BirthDay.ReadOnly = true;
            // 
            // People_PhoneNumber
            // 
            People_PhoneNumber.DataPropertyName = "PhoneNumber";
            People_PhoneNumber.HeaderText = "شماره همراه";
            People_PhoneNumber.Name = "People_PhoneNumber";
            People_PhoneNumber.ReadOnly = true;
            // 
            // People_Email
            // 
            People_Email.DataPropertyName = "Email";
            People_Email.HeaderText = "ایمیل";
            People_Email.Name = "People_Email";
            People_Email.ReadOnly = true;
            // 
            // Edit_Button
            // 
            Edit_Button.BackColor = SystemColors.HotTrack;
            Edit_Button.ForeColor = Color.White;
            Edit_Button.Location = new Point(621, 403);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Round = 25;
            Edit_Button.Size = new Size(87, 37);
            Edit_Button.TabIndex = 2;
            Edit_Button.Text = "ویرایش";
            Edit_Button.UseVisualStyleBackColor = false;
            Edit_Button.Click += Edit_Button_Click;
            // 
            // Information_TextBox
            // 
            Information_TextBox.Enabled = false;
            Information_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Information_TextBox.Location = new Point(12, 406);
            Information_TextBox.Name = "Information_TextBox";
            Information_TextBox.ReadOnly = true;
            Information_TextBox.RightToLeft = RightToLeft.Yes;
            Information_TextBox.Round = 25;
            Information_TextBox.Size = new Size(358, 29);
            Information_TextBox.TabIndex = 0;
            Information_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(720, 447);
            Controls.Add(Remove_Button);
            Controls.Add(Edit_Button);
            Controls.Add(Information_TextBox);
            Controls.Add(List_Box);
            Controls.Add(Search_Box);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "MainForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن";
            Search_Box.ResumeLayout(false);
            Search_Box.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            List_Box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)People_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Search_Box;
        private Resources.RoundedTextBox Search_TextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem AddPeople_ToolStrip;
        private ToolStripMenuItem AddUser_ToolStrip;
        private ToolStripMenuItem Update_ToolStrip;
        private ToolStripMenuItem ChangePassword_ToolStrip;
        private Resources.RoundedButton Remove_Button;
        private GroupBox List_Box;
        private Resources.RoundedTextBox Information_TextBox;
        private Resources.RoundedButton Edit_Button;
        private DataGridView People_DataGridView;
        private DataGridViewTextBoxColumn People_Id;
        private DataGridViewTextBoxColumn People_Name;
        private DataGridViewTextBoxColumn People_LastName;
        private DataGridViewTextBoxColumn People_Sex;
        private DataGridViewTextBoxColumn People_BirthDay;
        private DataGridViewTextBoxColumn People_PhoneNumber;
        private DataGridViewTextBoxColumn People_Email;
    }
}