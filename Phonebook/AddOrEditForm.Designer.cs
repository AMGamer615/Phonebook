namespace Phonebook
{
    partial class AddOrEditForm
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
            Sex_ComboBox = new Resources.RoundedComboBox(components);
            Submit_Button = new Resources.RoundedButton(components);
            Email_TextBox = new Resources.RoundedTextBox(components);
            BirthDay_TextBox = new Resources.RoundedTextBox(components);
            LastName_TextBox = new Resources.RoundedTextBox(components);
            PhoneNumber_TextBox = new Resources.RoundedTextBox(components);
            Name_TextBox = new Resources.RoundedTextBox(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Sex_ComboBox);
            groupBox1.Controls.Add(Submit_Button);
            groupBox1.Controls.Add(Email_TextBox);
            groupBox1.Controls.Add(BirthDay_TextBox);
            groupBox1.Controls.Add(LastName_TextBox);
            groupBox1.Controls.Add(PhoneNumber_TextBox);
            groupBox1.Controls.Add(Name_TextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(492, 187);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات فرد";
            // 
            // Sex_ComboBox
            // 
            Sex_ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            Sex_ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            Sex_ComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Sex_ComboBox.ForeColor = Color.Gray;
            Sex_ComboBox.FormattingEnabled = true;
            Sex_ComboBox.Items.AddRange(new object[] { "مرد", "زن" });
            Sex_ComboBox.Location = new Point(32, 64);
            Sex_ComboBox.Name = "Sex_ComboBox";
            Sex_ComboBox.PlaceholderText = "جنسیت";
            Sex_ComboBox.Round = 25;
            Sex_ComboBox.Size = new Size(198, 30);
            Sex_ComboBox.TabIndex = 6;
            Sex_ComboBox.TextAlign = HorizontalAlignment.Center;
            Sex_ComboBox.SelectedIndexChanged += Gender_ComboBox_SelectedIndexChanged;
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = SystemColors.HotTrack;
            Submit_Button.ForeColor = Color.White;
            Submit_Button.Location = new Point(200, 144);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Round = 25;
            Submit_Button.Size = new Size(87, 37);
            Submit_Button.TabIndex = 5;
            Submit_Button.Text = "افزودن";
            Submit_Button.UseVisualStyleBackColor = false;
            Submit_Button.Click += Submit_Button_Click;
            // 
            // Email_TextBox
            // 
            Email_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email_TextBox.Location = new Point(32, 99);
            Email_TextBox.Name = "Email_TextBox";
            Email_TextBox.PlaceholderText = "ایمیل";
            Email_TextBox.Round = 25;
            Email_TextBox.Size = new Size(198, 29);
            Email_TextBox.TabIndex = 3;
            Email_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BirthDay_TextBox
            // 
            BirthDay_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BirthDay_TextBox.Location = new Point(257, 99);
            BirthDay_TextBox.Name = "BirthDay_TextBox";
            BirthDay_TextBox.PlaceholderText = "تاریخ تولد";
            BirthDay_TextBox.Round = 25;
            BirthDay_TextBox.Size = new Size(198, 29);
            BirthDay_TextBox.TabIndex = 3;
            BirthDay_TextBox.TextAlign = HorizontalAlignment.Center;
            BirthDay_TextBox.KeyPress += BirthDay_TextBox_KeyPress;
            // 
            // LastName_TextBox
            // 
            LastName_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastName_TextBox.Location = new Point(32, 29);
            LastName_TextBox.Name = "LastName_TextBox";
            LastName_TextBox.PlaceholderText = "نام خانوادگی";
            LastName_TextBox.Round = 25;
            LastName_TextBox.Size = new Size(198, 29);
            LastName_TextBox.TabIndex = 3;
            LastName_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // PhoneNumber_TextBox
            // 
            PhoneNumber_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumber_TextBox.Location = new Point(257, 64);
            PhoneNumber_TextBox.MaxLength = 11;
            PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            PhoneNumber_TextBox.PlaceholderText = "شماره همراه";
            PhoneNumber_TextBox.Round = 25;
            PhoneNumber_TextBox.Size = new Size(198, 29);
            PhoneNumber_TextBox.TabIndex = 3;
            PhoneNumber_TextBox.TextAlign = HorizontalAlignment.Center;
            PhoneNumber_TextBox.KeyPress += PhoneNumber_TextBox_KeyPress;
            // 
            // Name_TextBox
            // 
            Name_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name_TextBox.Location = new Point(257, 29);
            Name_TextBox.Name = "Name_TextBox";
            Name_TextBox.PlaceholderText = "نام";
            Name_TextBox.Round = 25;
            Name_TextBox.Size = new Size(198, 29);
            Name_TextBox.TabIndex = 3;
            Name_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddOrEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(516, 210);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddOrEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن شخص جدید";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        public Resources.RoundedTextBox Name_TextBox;
        public Resources.RoundedButton Submit_Button;
        public Resources.RoundedTextBox Email_TextBox;
        public Resources.RoundedTextBox BirthDay_TextBox;
        public Resources.RoundedTextBox LastName_TextBox;
        public Resources.RoundedTextBox PhoneNumber_TextBox;
        public Resources.RoundedComboBox Sex_ComboBox;
    }
}