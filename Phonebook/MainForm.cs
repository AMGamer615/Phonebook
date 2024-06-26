﻿using Phonebook.Resources;
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
    public partial class MainForm : Form
    {
        private IPeople people;
        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = this.Edit_Button;
            Information_TextBox.Text = $"{CurrentUser.FullFamily} خوش آمدید {DateConvertor.ToShamsi(DateTime.Now)}";
            if (!CurrentUser.IsAdmin)
            {
                AddUser_ToolStrip.Enabled = false;
                AddUser_ToolStrip.Visible = false;
                Remove_Button.Enabled = false;
                Remove_Button.Visible = false;
            }
            people = new PeopleService();
            List<PeopleViewModel> peoples = people.GetAll();
            People_DataGridView.DataSource = peoples;
            People_DataGridView.ClearSelection();
        }

        private void ChangePassword_ToolStrip_Click(object sender, EventArgs e)
        {
            ChangePassForm form = new ChangePassForm();
            form.ShowDialog();
        }

        private void AddPeople_ToolStrip_Click(object sender, EventArgs e)
        {
            AddOrEditForm form = new AddOrEditForm();
            form.DataGridView = People_DataGridView;
            form.search = Search_TextBox;
            form.ShowDialog();
        }

        private void AddUser_ToolStrip_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.ShowDialog();
        }

        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            List<PeopleViewModel> peoples = people.Search(Search_TextBox.Text);
            People_DataGridView.DataSource = peoples;
            List<string> columnnames = new List<string>() { "People_Name" , "People_LastName" , "People_PhoneNumber" };
            People_DataGridView.ClearSelection();
            foreach (var columnname in columnnames) {
                foreach (DataGridViewRow row in People_DataGridView.Rows)
                {
                    var cell = row.Cells[columnname];
                    if (Convert.ToString(cell.Value).Contains(Search_TextBox.Text) && Search_TextBox.Text != string.Empty)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }

        private void Update_ToolStrip_Click(object sender, EventArgs e)
        {
            Search_TextBox.Text = string.Empty;
            this.ActiveControl = this.Edit_Button;
            List<PeopleViewModel> peoples = people.GetAll();
            People_DataGridView.DataSource = peoples;
            People_DataGridView.ClearSelection();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection cells = People_DataGridView.SelectedCells;
            foreach (DataGridViewCell cell in cells)
            {
                int Id = Convert.ToInt32(cell.OwningRow.Cells["People_Id"].Value);
                people.Delete(Id);
            }
            if (Search_TextBox.Text == string.Empty)
            {
                People_DataGridView.DataSource = people.GetAll();
                People_DataGridView.ClearSelection();
            }
            else
            {
                People_DataGridView.DataSource = people.Search(Search_TextBox.Text);
                List<string> columnnames = new List<string>() { "People_Name", "People_LastName", "People_PhoneNumber" };
                People_DataGridView.ClearSelection();
                foreach (var columnname in columnnames)
                {
                    foreach (DataGridViewRow row in People_DataGridView.Rows)
                    {
                        var cell = row.Cells[columnname];
                        if (Convert.ToString(cell.Value).Contains(Search_TextBox.Text) && Search_TextBox.Text != string.Empty)
                        {
                            cell.Selected = true;
                        }
                    }
                }
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = People_DataGridView.SelectedCells[0];
                AddOrEditForm form = new AddOrEditForm();
                form.search = Search_TextBox;
                form.Text = "ویرایش شخص";
                form.Submit_Button.Text = "ذخیره";
                form.DataGridView = People_DataGridView;
                int Id = Convert.ToInt32(cell.OwningRow.Cells["People_Id"].Value);
                form.Id = Id;
                form.Name_TextBox.Text = Convert.ToString(cell.OwningRow.Cells["People_Name"].Value);
                form.LastName_TextBox.Text = Convert.ToString(cell.OwningRow.Cells["People_LastName"].Value);
                form.Sex_ComboBox.Text = Convert.ToString(cell.OwningRow.Cells["People_Sex"].Value);
                form.BirthDay_TextBox.Text = Convert.ToString(cell.OwningRow.Cells["People_BirthDay"].Value);
                form.PhoneNumber_TextBox.Text = Convert.ToString(cell.OwningRow.Cells["People_PhoneNumber"].Value);
                form.Email_TextBox.Text = Convert.ToString(cell.OwningRow.Cells["People_Email"].Value);
                form.ShowDialog();
            }
            catch { }
        }
    }
}
