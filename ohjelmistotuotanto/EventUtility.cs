using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ohjelmistotuotanto.EventUtility;
//using static ohjelmistotuotanto.EventUtility;

namespace ohjelmistotuotanto
{
    public class EventUtility
    {
        public delegate void SearchResultsReceived<T>(List<T> results); // Function pointer 
        public static event SearchResultsReceived<Reservation> DisplayReservationSearchResults;

        public static void RaiseDisplayReservationSearchResults(List<Reservation> results)
        {
            if (DisplayReservationSearchResults != null)
            {
                DisplayReservationSearchResults(results);
            }
        }
    }
}
