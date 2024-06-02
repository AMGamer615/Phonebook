using PhoneBook.Datalayer.Convertor;
using PhoneBook.Datalayer.DTOs;
using PhoneBook.Datalayer.Entities.User;
using PhoneBook.Datalayer.Model;
using PhoneBook.Datalayer.Repository;
using PhoneBook.Datalayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
            setuser();
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
        private void setuser()
        {
            MyDbContext DB = new MyDbContext();
            Role Admin = new Role()
            {
                RoleId = 1,
                RoleTitle = "Admin"
            };
            DB.Roles.AddOrUpdate(Admin);
            Role user = new Role()
            {
                RoleId = 2,
                RoleTitle = "User"
            };
            DB.Roles.AddOrUpdate(user);
            DB.SaveChanges();
            UserViewModel UVM = new UserViewModel();
            UVM.UserId = 1;
            UVM.UserName = "Amirmahdi";
            UVM.Password = MD5Hash.MD5Hashing("123");
            UVM.FullFamily = "امیرمهدی راحت";
            UVM.PhoneNumber = "09687258643";
            UVM.BirthDay = "1382/04/07";
            UVM.Email = "Amirmahdi@gmail.com";
            UVM.RoleId = 1;
            UVM.Sex = "مرد";
            UVM.NationalID = "0204867193";
            User.Insert(UVM);
        }
    }
}
