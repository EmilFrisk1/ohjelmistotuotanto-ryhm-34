using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class ServicesReport
    {
        public string AlueNimi { get; set; }
        public int Määrä { get; set; }
        public int VarausId { get; set; }
        public string PalvelunNimi { get; set; }
        public decimal Hinta { get; set; }
        public DateTime AloitusPvm { get; set; }
    }
}
