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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Phonebook
{
    public partial class AddOrEditForm : Form
    {
        private IPeople people;

        public DataGridView DataGridView { get; set; }
        public int? Id { get; set; } = null;

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
            PeopleViewModel peopleVM = new PeopleViewModel();
            if (this.Id is int Id)
            {
                peopleVM.PeopleId = Id;
            }
            peopleVM.Name = Name_TextBox.Text;
            peopleVM.LastName = LastName_TextBox.Text;
            peopleVM.Sex = Sex_ComboBox.Text;
            peopleVM.BirthDay = BirthDay_TextBox.Text;
            peopleVM.PhoneNumber = PhoneNumber_TextBox.Text;
            peopleVM.Email = Email_TextBox.Text;

            if (people.Insert(peopleVM))
            {
                this.Hide();
                DataGridView.DataSource = people.GetAll();
                this.Close();
            }
            else
            {
                MessageBox.Show("اطلاعات وارد شده صحیح نمی باشد");
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
    }
}
