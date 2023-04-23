using ohjelmistotuotanto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ComboBoxUtility
{
    public static void FilterCottages(ComboBox comboBox, List<Cottage> cottages, string searchText)
    {
        if (string.IsNullOrEmpty(searchText)) // default list
        {
            comboBox.DataSource = null;
            comboBox.DataSource = cottages;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
        else
        { // filtered list
            List<Cottage> filteredCottages = new List<Cottage>();

            foreach (Cottage cottage in cottages)
            {
                bool contains = cottage.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

                if (contains)
                { // match 
                    if (!(filteredCottages.Contains(cottage)))
                    {
                        filteredCottages.Add(cottage);
                    }
                }
            }

            comboBox.DataSource = null;
            comboBox.DataSource = filteredCottages;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
    }


    public static void FilterCustomers(ComboBox comboBox, List<Customer> customers, string searchText)
    {
        if (string.IsNullOrEmpty(searchText)) // default list
        {
            comboBox.DataSource = null;
            comboBox.DataSource = customers;
            comboBox.DisplayMember = "Email";
            comboBox.ValueMember = "Id";
        }
        else
        { // filtered list
            List<Customer> filteredCustomers = new List<Customer>();

            foreach (Customer customer in customers)
            {
                bool contains = customer.Email.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

                if (contains)
                { // match 
                    if (!(filteredCustomers.Contains(customer)))
                    {
                        filteredCustomers.Add(customer);
                    }
                }
            }

            comboBox.DataSource = null;
            comboBox.DataSource = filteredCustomers;
            comboBox.DisplayMember = "Email";
            comboBox.ValueMember = "Id";
        }
    }

}
