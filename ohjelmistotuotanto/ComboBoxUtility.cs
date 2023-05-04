using ohjelmistotuotanto;
using System;
using System.Collections.Generic;
using System.Data;
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

    public static void FilterCottages(ComboBox comboBox, List<CottageDataModel> cottages, string searchText)
    {
        if (string.IsNullOrEmpty(searchText)) // default list
        {
            comboBox.DataSource = null;
            comboBox.DataSource = cottages;
            comboBox.DisplayMember = "CottageName";
            comboBox.ValueMember = "Id";
        }
        else
        { // filtered list
            List<CottageDataModel> filteredCottages = new List<CottageDataModel>();

            foreach (CottageDataModel cottage in cottages)
            {
                bool contains = cottage.CottageName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0;

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
            comboBox.DisplayMember = "CottageName";
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

    public static void setUpServicesCbx(DataTable services, List<Service> Services, ComboBox servicesCbx)
    {
        if (services.Rows != null && services.Rows.Count > 0)
        {
            servicesCbx.DataSource = null;
            Services.RemoveRange(1, Services.Count - 1);
            foreach (DataRow row in services.Rows)
            {
                var id = (int)row[0];
                var name = (string)row[1];

                Services.Add(new Service { Id = id, Name = name });
            }
            servicesCbx.DataSource = Services;
            servicesCbx.DisplayMember = "Name";
            servicesCbx.ValueMember = "Id";
        }
    }

    public static void SetUpCottagesCbx(DataTable cottages, List<Cottage> Cottages, ComboBox cottageCbx)
    {
        if (cottages.Rows != null && cottages.Rows.Count > 0)
        {
            cottageCbx.DataSource = null;
            foreach (DataRow row in cottages.Rows)
            {
                var id = (int)row[0];
                var name = (string)row[1];

                Cottages.Add(new Cottage { Id = id, Name = name });
            }
            cottageCbx.DataSource = Cottages;
            cottageCbx.DisplayMember = "Name";
            cottageCbx.ValueMember = "Id";
        }
    }

    public static void SetUpCottagesCbx(DataTable cottages, List<CottageDataModel> Cottages, ComboBox cottageCbx)
    {
        if (cottages.Rows != null && cottages.Rows.Count > 0)
        {
            cottageCbx.DataSource = null;
            foreach (DataRow row in cottages.Rows)
            {
                var id = (int)row[0];
                var areaId = (int)row[1];
                var price = (decimal)row[2];
                var description = (string)row[3];
                var equipment = (string)row[4];
                var squares = (int)row[5];
                var address = (string)row[6];
                var cottageName = (string)row[7];

                Cottages.Add(new CottageDataModel { Id = id, AreaId = areaId, Price = price, Description = description, Equipment = equipment, Squares = squares, Address = address, CottageName = cottageName });
            }
            cottageCbx.DataSource = Cottages;
            cottageCbx.DisplayMember = "CottageName";
            cottageCbx.ValueMember = "Id";
        }
    }

    public static void SetUpCustomersCbx(DataTable customers, List<Customer> Customers, ComboBox customerCbx)
    {
        if (customers.Rows != null && customers.Rows.Count > 0)
        {
            foreach (DataRow row in customers.Rows)
            {
                var id = (int)row[0];
                var email = (string)row[1];

                Customers.Add(new Customer { Id = id, Email = email });
            }
            customerCbx.DataSource = Customers;
            customerCbx.DisplayMember = "Email";
            customerCbx.ValueMember = "Id";
        }
    }

    public static void SetUpAreasCbx(DataTable areas, List<Area> Areas, ComboBox areaCbx)
    {
        if (areas.Rows != null && areas.Rows.Count > 0)
        {
            foreach (DataRow row in areas.Rows)
            {
                var id = (int)row[0];
                var email = (string)row[1];

                Areas.Add(new Area { Id = id, Name = email });
            }
            areaCbx.DataSource = Areas;
            areaCbx.DisplayMember = "Name";
            areaCbx.ValueMember = "Id";
        }
    }
}
