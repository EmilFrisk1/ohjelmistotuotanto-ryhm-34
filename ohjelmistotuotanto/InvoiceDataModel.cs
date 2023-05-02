using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class InvoiceDataModel
    {
        public string BillId { get; set; }
        public string Sum { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }
        public string StartDate{ get; set; }
        public string EndDate { get; set; }
        public string CusCity { get; set; }
        public string CusPostalCode { get; set; }
        public string CusAddress { get; set; }
        public string CusName { get; set; }
        public string CottageDescription { get; set; }
        public string Alv { get; set; }
        public string FinalPrice { get; set; }
    }
}
