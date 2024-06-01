using Phonebook.Resources;
namespace Phonebook
{
    partial class LoginForm
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
            Login_PictureBox = new PictureBox();
            Username_TextBox = new RoundedTextBox(components);
            Password_TextBox = new RoundedTextBox(components);
            errorProvider = new ErrorProvider(components);
            Login_Button = new RoundedButton(components);
            Cancell_Button = new RoundedButton(components);
            ((System.ComponentModel.ISupportInitialize)Login_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // Login_PictureBox
            // 
            Login_PictureBox.Image = Properties.Resources.Icon;
            Login_PictureBox.Location = new Point(91, 24);
            Login_PictureBox.Name = "Login_PictureBox";
            Login_PictureBox.Size = new Size(131, 121);
            Login_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Login_PictureBox.TabIndex = 0;
            Login_PictureBox.TabStop = false;
            // 
            // Username_TextBox
            // 
            Username_TextBox.BackColor = SystemColors.Window;
            Username_TextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Username_TextBox.Location = new Point(99, 164);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.PlaceholderText = "نام کاربری";
            Username_TextBox.Round = 20;
            Username_TextBox.Size = new Size(116, 27);
            Username_TextBox.TabIndex = 4;
            Username_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_TextBox
            // 
            Password_TextBox.BackColor = SystemColors.Window;
            Password_TextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Password_TextBox.Location = new Point(99, 197);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "رمز عبور";
            Password_TextBox.Round = 20;
            Password_TextBox.Size = new Size(116, 27);
            Password_TextBox.TabIndex = 4;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            Password_TextBox.UseSystemPasswordChar = true;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Login_Button
            // 
            Login_Button.BackColor = SystemColors.HotTrack;
            Login_Button.ForeColor = Color.White;
            Login_Button.Location = new Point(159, 236);
            Login_Button.Name = "Login_Button";
            Login_Button.Round = 40;
            Login_Button.Size = new Size(84, 47);
            Login_Button.TabIndex = 8;
            Login_Button.Text = "ورود";
            Login_Button.UseVisualStyleBackColor = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Cancell_Button
            // 
            Cancell_Button.BackColor = SystemColors.ScrollBar;
            Cancell_Button.ForeColor = SystemColors.HotTrack;
            Cancell_Button.Location = new Point(69, 236);
            Cancell_Button.Name = "Cancell_Button";
            Cancell_Button.Round = 40;
            Cancell_Button.Size = new Size(84, 47);
            Cancell_Button.TabIndex = 8;
            Cancell_Button.Text = "انصراف";
            Cancell_Button.UseVisualStyleBackColor = false;
            Cancell_Button.Click += Cancell_Button_Click;
            // 
            // LoginForm
            // 
            AcceptButton = Login_Button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            CancelButton = Cancell_Button;
            ClientSize = new Size(321, 300);
            ControlBox = false;
            Controls.Add(Cancell_Button);
            Controls.Add(Login_Button);
            Controls.Add(Password_TextBox);
            Controls.Add(Username_TextBox);
            Controls.Add(Login_PictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "دفترچه تلفن";
            ((System.ComponentModel.ISupportInitialize)Login_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Login_PictureBox;
        private RoundedTextBox Username_TextBox;
        private RoundedTextBox Password_TextBox;
        private ErrorProvider errorProvider;
        private RoundedButton Cancell_Button;
        private RoundedButton Login_Button;
    }
}