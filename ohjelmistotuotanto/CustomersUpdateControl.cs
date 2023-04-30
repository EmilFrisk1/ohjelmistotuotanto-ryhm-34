﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ohjelmistotuotanto
{
    public partial class CustomersUpdateControl : UserControl
    {
        public delegate void MenuSwitchRequestHandler(string newControl); // Function pointer 
        public event MenuSwitchRequestHandler MenuSwitchRequested;
        public List<ClientDatamodel> ClientDatamodels { get; set; }
        public List<Customer> Customers { get; set; }

        public CustomersUpdateControl()
        {
            InitializeComponent();
        }
        
        void menuDefaultState()
        {
            customerTxtBox.Text = "";
            customerCbx.SelectedIndex = -1;
        }

        private void customerTxtBox_TextChanged(object sender, EventArgs e)
        {
            ComboBoxUtility.FilterCustomers(customerCbx, Customers, customerTxtBox.Text);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            VillageNewbies.menuhistory.RemoveAt(VillageNewbies.menuhistory.Count - 1);
            MenuSwitchRequested?.Invoke(Constants.customersMenu);
        }

        private async void CustomersUpdateControl_Load(object sender, EventArgs e)
        {
            var customers = await VillageNewbies._dbManager.SelectDataAsync("customer");
            setUpCustomersCbx(customers);
            menuDefaultState();
        }
        private void setUpCustomersCbx(DataTable customers)
        {
            if (customers.Rows != null && customers.Rows.Count > 0)
            {
                foreach (DataRow row in customers.Rows)
                {
                    var id = (int)row[0];
                    var email = (string)row[1];
                    var firstname = (string)row[2];
                    var lastname = (string)row[3];
                    var address = (string)row[4];
                    var postalnumber = (int)row[5];
                    var phonenumber = (string)row[6];
                    
                    if (ClientDatamodels == null)
                    {
                        ClientDatamodels = new List<ClientDatamodel>();
                    }

                    ClientDatamodels.Add(new ClientDatamodel
                    {
                        Id = id,
                        Email = email,
                        FirstName = firstname,
                        LastName = lastname,
                        Address = address,
                        PostalNumber = postalnumber,
                        PhoneNumber = phonenumber
                    });
                    if (Customers == null)
                    {
                        Customers = new List<Customer>();
                    }
                    Customers.Add(new Customer{
                        Id = id,
                        Email = email
                        
                    });
                }
                customerCbx.DataSource = ClientDatamodels;
                customerCbx.DisplayMember = "Email";
                customerCbx.ValueMember = "Id";
                
            }
        }
    }
}