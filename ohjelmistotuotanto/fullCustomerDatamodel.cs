using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class FullCustomerDatamodel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Phone { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
    }
}
