using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = this.Login_Button;
        }

        private void Cancell_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (Username_TextBox.Text != string.Empty && Password_TextBox.Text != string.Empty)
            {

            }
            else
            {
                if (Username_TextBox.Text == string.Empty)
                {
                    errorProvider.SetError(Username_TextBox, "لطفا نام کاربری خود را وارد کنید ");
                }
                if (Password_TextBox.Text == string.Empty)
                {
                    errorProvider.SetError(Password_TextBox, "لطفا کلمه عبور خود را وارد کنید ");
                }
            }
        }
    }
}
