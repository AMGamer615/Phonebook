namespace Phonebook
{
    partial class AddUser
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
            groupBox1 = new GroupBox();
            Email_TextBox = new Resources.RoundedTextBox(components);
            BirthDay_TextBox = new Resources.RoundedTextBox(components);
            PhoneNumber_TextBox = new Resources.RoundedTextBox(components);
            Role_ComboBox = new Resources.RoundedComboBox(components);
            Sex_ComboBox = new Resources.RoundedComboBox(components);
            Submit_Button = new Resources.RoundedButton(components);
            ConfirmPassword_TextBox = new Resources.RoundedTextBox(components);
            NationalID_TextBox = new Resources.RoundedTextBox(components);
            FullFamily_TextBox = new Resources.RoundedTextBox(components);
            UserName_TextBox = new Resources.RoundedTextBox(components);
            Password_TextBox = new Resources.RoundedTextBox(components);
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Email_TextBox);
            groupBox1.Controls.Add(BirthDay_TextBox);
            groupBox1.Controls.Add(PhoneNumber_TextBox);
            groupBox1.Controls.Add(Role_ComboBox);
            groupBox1.Controls.Add(Sex_ComboBox);
            groupBox1.Controls.Add(Submit_Button);
            groupBox1.Controls.Add(ConfirmPassword_TextBox);
            groupBox1.Controls.Add(NationalID_TextBox);
            groupBox1.Controls.Add(FullFamily_TextBox);
            groupBox1.Controls.Add(UserName_TextBox);
            groupBox1.Controls.Add(Password_TextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(542, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات کاربر";
            // 
            // Email_TextBox
            // 
            Email_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email_TextBox.Location = new Point(301, 173);
            Email_TextBox.Name = "Email_TextBox";
            Email_TextBox.PlaceholderText = "ایمیل";
            Email_TextBox.RightToLeft = RightToLeft.No;
            Email_TextBox.Round = 25;
            Email_TextBox.Size = new Size(198, 29);
            Email_TextBox.TabIndex = 8;
            Email_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BirthDay_TextBox
            // 
            BirthDay_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDay_TextBox.Location = new Point(301, 138);
            BirthDay_TextBox.Name = "BirthDay_TextBox";
            BirthDay_TextBox.PlaceholderText = "تاریخ تولد";
            BirthDay_TextBox.RightToLeft = RightToLeft.No;
            BirthDay_TextBox.Round = 25;
            BirthDay_TextBox.Size = new Size(198, 29);
            BirthDay_TextBox.TabIndex = 9;
            BirthDay_TextBox.TextAlign = HorizontalAlignment.Center;
            BirthDay_TextBox.KeyPress += BirthDay_TextBox_KeyPress;
            // 
            // PhoneNumber_TextBox
            // 
            PhoneNumber_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber_TextBox.Location = new Point(43, 67);
            PhoneNumber_TextBox.MaxLength = 11;
            PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            PhoneNumber_TextBox.PlaceholderText = "شماره همراه";
            PhoneNumber_TextBox.RightToLeft = RightToLeft.No;
            PhoneNumber_TextBox.Round = 25;
            PhoneNumber_TextBox.Size = new Size(198, 29);
            PhoneNumber_TextBox.TabIndex = 10;
            PhoneNumber_TextBox.TextAlign = HorizontalAlignment.Center;
            PhoneNumber_TextBox.KeyPress += PhoneNumber_TextBox_KeyPress;
            // 
            // Role_ComboBox
            // 
            Role_ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            Role_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Role_ComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Role_ComboBox.ForeColor = Color.Gray;
            Role_ComboBox.FormattingEnabled = true;
            Role_ComboBox.Location = new Point(43, 102);
            Role_ComboBox.Name = "Role_ComboBox";
            Role_ComboBox.PlaceholderText = "نقش";
            Role_ComboBox.RightToLeft = RightToLeft.No;
            Role_ComboBox.Round = 25;
            Role_ComboBox.Size = new Size(198, 30);
            Role_ComboBox.TabIndex = 7;
            Role_ComboBox.TextAlign = HorizontalAlignment.Center;
            Role_ComboBox.SelectedIndexChanged += Role_ComboBox_SelectedIndexChanged;
            // 
            // Sex_ComboBox
            // 
            Sex_ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            Sex_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Sex_ComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sex_ComboBox.ForeColor = Color.Gray;
            Sex_ComboBox.FormattingEnabled = true;
            Sex_ComboBox.Items.AddRange(new object[] { "مرد", "زن" });
            Sex_ComboBox.Location = new Point(301, 102);
            Sex_ComboBox.Name = "Sex_ComboBox";
            Sex_ComboBox.PlaceholderText = "جنسیت";
            Sex_ComboBox.Round = 25;
            Sex_ComboBox.Size = new Size(198, 30);
            Sex_ComboBox.TabIndex = 7;
            Sex_ComboBox.TextAlign = HorizontalAlignment.Center;
            Sex_ComboBox.SelectedIndexChanged += Sex_ComboBox_SelectedIndexChanged;
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = SystemColors.HotTrack;
            Submit_Button.ForeColor = Color.White;
            Submit_Button.Location = new Point(227, 220);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Round = 25;
            Submit_Button.Size = new Size(87, 37);
            Submit_Button.TabIndex = 4;
            Submit_Button.Text = "افزودن";
            Submit_Button.UseVisualStyleBackColor = false;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // ConfirmPassword_TextBox
            // 
            ConfirmPassword_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassword_TextBox.Location = new Point(43, 173);
            ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            ConfirmPassword_TextBox.PlaceholderText = "تکرار رمز عبور";
            ConfirmPassword_TextBox.RightToLeft = RightToLeft.No;
            ConfirmPassword_TextBox.Round = 25;
            ConfirmPassword_TextBox.Size = new Size(198, 29);
            ConfirmPassword_TextBox.TabIndex = 3;
            ConfirmPassword_TextBox.TextAlign = HorizontalAlignment.Center;
            ConfirmPassword_TextBox.UseSystemPasswordChar = true;
            // 
            // NationalID_TextBox
            // 
            NationalID_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NationalID_TextBox.Location = new Point(301, 67);
            NationalID_TextBox.MaxLength = 10;
            NationalID_TextBox.Name = "NationalID_TextBox";
            NationalID_TextBox.PlaceholderText = "کد ملی";
            NationalID_TextBox.RightToLeft = RightToLeft.No;
            NationalID_TextBox.Round = 25;
            NationalID_TextBox.Size = new Size(198, 29);
            NationalID_TextBox.TabIndex = 2;
            NationalID_TextBox.TextAlign = HorizontalAlignment.Center;
            NationalID_TextBox.KeyPress += NationalID_TextBox_KeyPress;
            // 
            // FullFamily_TextBox
            // 
            FullFamily_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullFamily_TextBox.Location = new Point(43, 32);
            FullFamily_TextBox.Name = "FullFamily_TextBox";
            FullFamily_TextBox.PlaceholderText = "نام و نام خانوادگی";
            FullFamily_TextBox.Round = 25;
            FullFamily_TextBox.Size = new Size(198, 29);
            FullFamily_TextBox.TabIndex = 2;
            FullFamily_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UserName_TextBox
            // 
            UserName_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UserName_TextBox.Location = new Point(301, 32);
            UserName_TextBox.Name = "UserName_TextBox";
            UserName_TextBox.PlaceholderText = "نام کاربری";
            UserName_TextBox.RightToLeft = RightToLeft.No;
            UserName_TextBox.Round = 25;
            UserName_TextBox.Size = new Size(198, 29);
            UserName_TextBox.TabIndex = 2;
            UserName_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_TextBox.Location = new Point(43, 138);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "رمز عبور";
            Password_TextBox.RightToLeft = RightToLeft.No;
            Password_TextBox.Round = 25;
            Password_TextBox.Size = new Size(198, 29);
            Password_TextBox.TabIndex = 2;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            Password_TextBox.UseSystemPasswordChar = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(566, 300);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن کاربر جدید";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Resources.RoundedTextBox Password_TextBox;
        private Resources.RoundedTextBox ConfirmPassword_TextBox;
        private Resources.RoundedButton Submit_Button;
        private Resources.RoundedTextBox UserName_TextBox;
        private Resources.RoundedTextBox FullFamily_TextBox;
        public Resources.RoundedComboBox Sex_ComboBox;
        public Resources.RoundedTextBox Email_TextBox;
        public Resources.RoundedTextBox BirthDay_TextBox;
        public Resources.RoundedTextBox PhoneNumber_TextBox;
        private Resources.RoundedTextBox NationalID_TextBox;
        public Resources.RoundedComboBox Role_ComboBox;
        private ErrorProvider errorProvider1;
    }
}