using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class ReservationDetails
    {
        public int Id { get; set; }
        public DateTime AloitusPvm { get; set; }
        public DateTime LoppuPvm { get; set; }
        public string Email { get; set; }
        public string MökinNimi { get; set; }
    }

}
