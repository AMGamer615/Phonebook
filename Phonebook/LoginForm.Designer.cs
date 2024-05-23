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
            Login_Button = new Button();
            Cancell_Button = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)Login_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // Login_PictureBox
            // 
            Login_PictureBox.Image = Properties.Resources.Icon;
            Login_PictureBox.Location = new Point(96, 27);
            Login_PictureBox.Name = "Login_PictureBox";
            Login_PictureBox.Size = new Size(121, 113);
            Login_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Login_PictureBox.TabIndex = 0;
            Login_PictureBox.TabStop = false;
            // 
            // Username_TextBox
            // 
            Username_TextBox.BackColor = SystemColors.Window;
            Username_TextBox.Location = new Point(107, 160);
            Username_TextBox.Name = "Username_TextBox";
            Username_TextBox.PlaceholderText = "Username";
            Username_TextBox.Round = 15;
            Username_TextBox.Size = new Size(100, 23);
            Username_TextBox.TabIndex = 4;
            Username_TextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Password_TextBox
            // 
            Password_TextBox.BackColor = SystemColors.Window;
            Password_TextBox.Location = new Point(107, 202);
            Password_TextBox.Name = "Password_TextBox";
            Password_TextBox.PlaceholderText = "Password";
            Password_TextBox.Round = 15;
            Password_TextBox.Size = new Size(100, 23);
            Password_TextBox.TabIndex = 4;
            Password_TextBox.TextAlign = HorizontalAlignment.Center;
            Password_TextBox.UseSystemPasswordChar = true;
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(160, 245);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(76, 23);
            Login_Button.TabIndex = 7;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click;
            // 
            // Cancell_Button
            // 
            Cancell_Button.Location = new Point(78, 245);
            Cancell_Button.Name = "Cancell_Button";
            Cancell_Button.Size = new Size(76, 23);
            Cancell_Button.TabIndex = 7;
            Cancell_Button.Text = "Cancell";
            Cancell_Button.UseVisualStyleBackColor = true;
            Cancell_Button.Click += Cancell_Button_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // LoginForm
            // 
            AcceptButton = Login_Button;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
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
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)Login_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Login_PictureBox;
        private RoundedTextBox Username_TextBox;
        private RoundedTextBox Password_TextBox;
        private Button Login_Button;
        private Button Cancell_Button;
        private ErrorProvider errorProvider;
    }
}