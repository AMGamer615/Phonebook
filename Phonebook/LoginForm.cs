using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Repository;
using PhoneBook.Datalayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class LoginForm : Form
    {
        private IUser User;
        private IRole Role;
        public LoginForm()
        {
            InitializeComponent();
            this.ActiveControl = this.Login_Button;
            User = new UserService();
            Role = new RoleService();
        }

        private void Cancell_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                if (Username_TextBox.Text != string.Empty && Password_TextBox.Text != string.Empty)
                {
                    UserViewModel UserVM = User.SelectUserByPassword(Username_TextBox.Text, MD5Hash.MD5Hashing(Password_TextBox.Text));
                    if (UserVM != null)
                    {
                        this.Hide();
                        CurrentUser.UserName = UserVM.UserName;
                        CurrentUser.FullFamily = UserVM.FullFamily;
                        Dictionary<int,string> Roles = Role.GetRoles();
                        if (Roles[UserVM.RoleId] == "Admin")
                        {
                            CurrentUser.IsAdmin = true;
                        }
                        MainForm form = new MainForm();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا کلمه عبور اشتباه می باشد");
                    }
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
            catch (Exception ex)
            {
                MessageBox.Show("خطا دوباره تلاش کنید");
            }
        }
    }
}
