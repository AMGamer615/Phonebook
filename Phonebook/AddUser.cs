using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Repository;
using PhoneBook.Datalayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class AddUser : Form
    {
        private IRole Role;
        private IUser User;
        public AddUser()
        {
            InitializeComponent();
            this.ActiveControl = Submit_Button;
            Role = new RoleService();
            User = new UserService();
            Role_ComboBox.Items.AddRange(Role.GetRoles().Values.ToArray());
            Role_ComboBox.SelectedIndex = 0;
        }

        private void Role_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = Submit_Button;
        }

        private void Sex_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = Submit_Button;
        }

        private void PhoneNumber_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void NationalID_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void BirthDay_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.OemBackslash && e.KeyChar != (char)Keys.Back && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Password_TextBox.Text != ConfirmPassword_TextBox.Text)
            {
                errorProvider1.SetError(Password_TextBox, " ");
                errorProvider1.SetError(ConfirmPassword_TextBox, " ");
                return;
            }
            int role = 0;
            foreach (var item in Role.GetRoles())
            {
                if (item.Value == Role_ComboBox.Text)
                {
                    role = item.Key;
                    break;
                }
            }
            UserViewModel UserVM = new UserViewModel();
            UserVM.UserName = UserName_TextBox.Text;
            UserVM.FullFamily = FullFamily_TextBox.Text;
            UserVM.Sex = Sex_ComboBox.Text;
            UserVM.NationalID = NationalID_TextBox.Text;
            UserVM.BirthDay = BirthDay_TextBox.Text;
            UserVM.PhoneNumber = PhoneNumber_TextBox.Text;
            UserVM.Email = Email_TextBox.Text;
            UserVM.Password = MD5Hash.MD5Hashing(Password_TextBox.Text);
            UserVM.RoleId = role;
            if (User.Insert(UserVM))
            {
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد");
            }
        }
    }
}
