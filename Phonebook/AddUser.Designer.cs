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
            Submit_Button = new Resources.RoundedButton(components);
            ConfirmPassword_TextBox = new Resources.RoundedTextBox(components);
            Password_TextBox = new Resources.RoundedTextBox(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Submit_Button);
            groupBox1.Controls.Add(ConfirmPassword_TextBox);
            groupBox1.Controls.Add(Password_TextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(567, 261);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات کاربر";
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = SystemColors.HotTrack;
            Submit_Button.ForeColor = Color.White;
            Submit_Button.Location = new Point(238, 202);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Round = 25;
            Submit_Button.Size = new Size(87, 37);
            Submit_Button.TabIndex = 4;
            Submit_Button.Text = "افزودن";
            Submit_Button.UseVisualStyleBackColor = false;
            // 
            // ConfirmPassword_TextBox
            // 
            ConfirmPassword_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassword_TextBox.Location = new Point(184, 151);
            ConfirmPassword_TextBox.Name = "ConfirmPassword_TextBox";
            ConfirmPassword_TextBox.PlaceholderText = "تکرار رمز عبور";
            ConfirmPassword_TextBox.Round = 25;
            ConfirmPassword_TextBox.Size = new Size(198, 29);
            ConfirmPassword_TextBox.TabIndex = 3;
            ConfirmPassword_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_TextBox
            // 
            Password_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_TextBox.Location = new Point(184, 116);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "رمز عبور";
            Password_TextBox.Round = 25;
            Password_TextBox.Size = new Size(198, 29);
            Password_TextBox.TabIndex = 2;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(591, 285);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن کاربر جدید";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Resources.RoundedTextBox Password_TextBox;
        private Resources.RoundedTextBox ConfirmPassword_TextBox;
        private Resources.RoundedButton Submit_Button;
    }
}