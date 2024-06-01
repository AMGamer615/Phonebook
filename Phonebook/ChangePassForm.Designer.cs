namespace Phonebook
{
    partial class ChangePassForm
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
            Password_TextBox = new Resources.RoundedTextBox(components);
            NewPassword_TextBox = new Resources.RoundedTextBox(components);
            ConfirmNewPassword_TextBox = new Resources.RoundedTextBox(components);
            Submit_Button = new Resources.RoundedButton(components);
            SuspendLayout();
            // 
            // Password_TextBox
            // 
            Password_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password_TextBox.Location = new Point(62, 19);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "رمز عبور";
            Password_TextBox.Round = 25;
            Password_TextBox.Size = new Size(198, 29);
            Password_TextBox.TabIndex = 1;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // NewPassword_TextBox
            // 
            NewPassword_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewPassword_TextBox.Location = new Point(62, 54);
            NewPassword_TextBox.Name = "NewPassword_TextBox";
            NewPassword_TextBox.PlaceholderText = "رمز عبور جدید";
            NewPassword_TextBox.Round = 25;
            NewPassword_TextBox.Size = new Size(198, 29);
            NewPassword_TextBox.TabIndex = 1;
            NewPassword_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ConfirmNewPassword_TextBox
            // 
            ConfirmNewPassword_TextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmNewPassword_TextBox.Location = new Point(62, 89);
            ConfirmNewPassword_TextBox.Name = "ConfirmNewPassword_TextBox";
            ConfirmNewPassword_TextBox.PlaceholderText = "تکرار رمز عبور جدید";
            ConfirmNewPassword_TextBox.Round = 25;
            ConfirmNewPassword_TextBox.Size = new Size(198, 29);
            ConfirmNewPassword_TextBox.TabIndex = 1;
            ConfirmNewPassword_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Submit_Button
            // 
            Submit_Button.BackColor = SystemColors.HotTrack;
            Submit_Button.ForeColor = Color.White;
            Submit_Button.Location = new Point(117, 133);
            Submit_Button.Name = "Submit_Button";
            Submit_Button.Round = 25;
            Submit_Button.Size = new Size(87, 37);
            Submit_Button.TabIndex = 3;
            Submit_Button.Text = "انجام";
            Submit_Button.UseVisualStyleBackColor = false;
            // 
            // ChangePassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(315, 182);
            Controls.Add(Submit_Button);
            Controls.Add(ConfirmNewPassword_TextBox);
            Controls.Add(NewPassword_TextBox);
            Controls.Add(Password_TextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ChangePassForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تغییر رمز عبور";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Resources.RoundedTextBox Password_TextBox;
        private Resources.RoundedTextBox NewPassword_TextBox;
        private Resources.RoundedTextBox ConfirmNewPassword_TextBox;
        private Resources.RoundedButton Submit_Button;
    }
}