using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class CottageDataModel
    {
        public int Id { get; set; }
        public int AreaId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Equipment { get; set; }
        public int Squares { get; set; }
        public string Address { get; set; }
        public string CottageName { get; set; }
    }
}
