using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohjelmistotuotanto
{
    public class Reservation
    {
        public int Id { get; set; }
        public int MökkiId { get; set; }
        public DateTime AloitusPvm { get; set; }
        public DateTime LoppuPvm { get; set; }
        public int AsiakasId { get; set; }
    }
}
