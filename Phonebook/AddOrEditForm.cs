using Phonebook.Resources;
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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phonebook
{
    public partial class AddOrEditForm : Form
    {
        private IPeople people;

        public DataGridView DataGridView { get; set; }
        public int? Id { get; set; } = null;
        public TextBox search {  get; set; }

        public AddOrEditForm()
        {
            InitializeComponent();
            this.ActiveControl = Submit_Button;
            people = new PeopleService();
        }

        private void Gender_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActiveControl = Submit_Button;
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            PeopleViewModel peopleVM = new PeopleViewModel();
            if (this.Id is int Id)
            {
                peopleVM.PeopleId = Id;
            }

            if (!Validation())
                return;

            peopleVM.Name = Name_TextBox.Text;
            peopleVM.LastName = LastName_TextBox.Text;
            peopleVM.Sex = Sex_ComboBox.Text;
            peopleVM.BirthDay = BirthDay_TextBox.Text;
            peopleVM.PhoneNumber = PhoneNumber_TextBox.Text;
            peopleVM.Email = Email_TextBox.Text;

            if (people.Insert(peopleVM))
            {
                this.Hide();
                if (search.Text == string.Empty)
                    DataGridView.DataSource = people.GetAll();
                else
                    DataGridView.DataSource = people.Search(search.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("خطا");
            }
        }

        private void PhoneNumber_TextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private bool Validation()
        {
            bool Validation = true;

            try
            {
                Convert.ToDateTime(BirthDay_TextBox.Text);
            }
            catch
            {
                Validation = false;
                errorProvider1.SetError(BirthDay_TextBox, $"فرمت تاریخ وارد شده صحیح نمی باشد");
            }

            try
            {
                var Email = new MailAddress(Email_TextBox.Text);
            }
            catch
            {
                Validation = false;
                errorProvider1.SetError(Email_TextBox, "فرمت ایمیل وارد شده صحیح نمی باشد");
            }

            if (!Email_TextBox.Text.EndsWith(".com"))
                Validation = false;

            List<Control> list = new List<Control>() { Name_TextBox, LastName_TextBox, Sex_ComboBox, BirthDay_TextBox, PhoneNumber_TextBox, Email_TextBox};

            foreach (Control c in list)
            {
                if (c.Text == string.Empty)
                {
                    Validation = false;
                    if (c is RoundedTextBox r)
                        errorProvider1.SetError(c, $"لطفا {r.PlaceholderText} را وارد کنید");
                    else if (c is RoundedComboBox rc)
                        errorProvider1.SetError(c, $"لطفا {rc.PlaceholderText} را وارد کنید");
                }
            }
            
            return Validation;
        }
    }
}
