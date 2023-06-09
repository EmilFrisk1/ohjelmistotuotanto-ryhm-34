﻿using System;
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
        public static event SearchResultsReceived<ServicesReport> DisplayServicesSearchResults;
        public static event SearchResultsReceived<CottageDataModel> DisplayCottagesSearchResults;

        public static void RaiseDisplayReservationSearchResults(List<Reservation> results)
        {
            if (DisplayReservationSearchResults != null)
            {
                DisplayReservationSearchResults(results);
            }
        }

        public static void RaiseDisplayServicesSearchResults(List<ServicesReport> results)
        {
            if (DisplayServicesSearchResults != null)
            {
                DisplayServicesSearchResults(results);
            }
        }

        public static void RaiseDisplayCottagesSearchResults(List<CottageDataModel> results)
        {
            if (DisplayCottagesSearchResults != null)
            {
                DisplayCottagesSearchResults(results);
            }
        }
    }
}
