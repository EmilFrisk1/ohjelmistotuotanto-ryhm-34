﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmistotuotanto
{
    public partial class CustomersSearchControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public StatusStrip statusStrip;
        public CustomersSearchControl()
        {
            InitializeComponent();
        }
        void menuDefaultState()
        {
            firstNameTxtBox.Text = "";
            lastNameTxtBox.Text = "";
            emailTxtBox.Text = "";
            phoneNumberTxtBox.Text = "";
            addressTxtBox.Text = "";
            postalCodeTxtBox.Text = "";
            cityTxtBox.Text = "";
        }
        private void addCustomertxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            Utility.DefaultStatusStrip(statusStrip);
            Utility.HideErrors(statusStrip);
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private async void addCustomerBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            Dictionary<string, object> customerColumnValues = new Dictionary<string, object>
                                {
                                    { "email",emailTxtBox.Text},
                                    { "firstname", firstNameTxtBox.Text},
                                    { "lastname", lastNameTxtBox.Text},
                                    { "phone", phoneNumberTxtBox.Text.Replace(" ", "")},
                                    { "postal_code", postalCodeTxtBox.Text.Replace(" ", "")},
                                    { "address", addressTxtBox.Text},
                                    { "city", cityTxtBox.Text},
                                };

            int billInsRes = await VillageNewbies._dbManager.InsertDataAsync("customer", customerColumnValues);
            if (billInsRes <= 0)
            {
                MessageBox.Show("Error occurred while inserting data into the database.");
            }
            else
            {
                MessageBox.Show("Asiakas lisätty onnistuneesti!");
            }
            menuDefaultState();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrEmpty(firstNameTxtBox.Text) || string.IsNullOrEmpty(lastNameTxtBox.Text) ||
                string.IsNullOrEmpty(emailTxtBox.Text) || string.IsNullOrEmpty(phoneNumberTxtBox.Text) ||
                string.IsNullOrEmpty(addressTxtBox.Text) || string.IsNullOrEmpty(postalCodeTxtBox.Text) || string.IsNullOrEmpty(cityTxtBox.Text))
            {
                statusStrip.Show();
                return false;
            }
            else
            {
                if (statusStrip.Visible)
                {
                    statusStrip.Hide();
                    return true;
                }
                return true;
            }
        }

        private void CustomersSearchControl_Load(object sender, EventArgs e)
        {

        }

        private void phoneNumberTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextBoxUtility.MaxLength(sender, e, 18))
            {
                Utility.UpdateStatusStripText("Vain 18 merrkiä sallittu", statusStrip);
                statusStrip.Visible = true;
                return;
            }
            else
            {
                if (statusStrip.Visible) statusStrip.Hide();
            }

            if (TextBoxUtility.AllowOnlyNumbers(sender, e))
            {
                Utility.UpdateStatusStripText("Vain numerot ja yksi piste sallittu", statusStrip);
                statusStrip.Visible = true;
                return;
            }
            else
            {
                if (statusStrip.Visible) statusStrip.Hide();
            }

        }

        private void postalCodeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!TextBoxUtility.MaxLength(sender, e, 9))
            {
                Utility.UpdateStatusStripText("Vain 9 merrkiä sallittu", statusStrip);
                statusStrip.Visible = true;
                return;
            }
            else
            {
                if (statusStrip.Visible) statusStrip.Hide();
            }

            if (TextBoxUtility.AllowOnlyNumbers(sender, e))
            {
                Utility.UpdateStatusStripText("Vain numerot ja yksi piste sallittu", statusStrip);
                statusStrip.Visible = true;
                return;
            }
            else
            {
                if (statusStrip.Visible) statusStrip.Hide();
            }
        }

        private void phoneNumberTxtBox_Leave(object sender, EventArgs e)
        {
            if (statusStrip.Visible) { statusStrip.Hide(); }
        }

        private void postalCodeTxtBox_Leave(object sender, EventArgs e)
        {
            if (statusStrip.Visible) { statusStrip.Hide(); }
        }
    }
}
