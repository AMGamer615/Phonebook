using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.Repository;
using PhoneBook.Datalayer.Services;
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
    public partial class ChangePassForm : Form
    {
        private IUser user;
        public ChangePassForm()
        {
            InitializeComponent();
            this.ActiveControl = this.Submit_Button;
            user = new UserService();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (NewPassword_TextBox.Text == ConfirmNewPassword_TextBox.Text)
            {
                if (user.ChangedPass(CurrentUser.UserName, MD5Hash.MD5Hashing(Password_TextBox.Text), MD5Hash.MD5Hashing(NewPassword_TextBox.Text)))
                {
                    this.Hide();
                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(Password_TextBox, "رمز عبور صحیح نمی باشد");
                }
            }
            else
            {
                errorProvider1.SetError(NewPassword_TextBox, "رمز عبور جدید و تکرار رمز عبور جدید باید با هم برابر باشند");
                errorProvider1.SetError(ConfirmNewPassword_TextBox, "رمز عبور جدید و تکرار کلمه رمز جدید باید با هم برابر باشند");
            }
        }
    }
}
