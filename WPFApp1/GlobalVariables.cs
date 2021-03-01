using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp1
{
    class GlobalVariables
    {
        public static decimal AdultPrice = 12.50m;
        public static decimal ChildPrice = 6.00m;
        public static decimal ConcessionPrice = 8.25m;
        public static decimal StudentPrice = 10.00m;

        public static string FilmTime { get; set; }
        public static string FilmDay { get; set; }
        public static string FilmName { get; set; }
        public static decimal TotalPrice { get; set; }
        public static string SeatChoice { get; set; }
        public static string TicketType { get; set; }
        public static string SelectedAmount { get; set; }
        public static string Index { get; set; }
        public static string StoreFilmName { get; set; }
        public static string StoreExtraName { get; set; }
        public static List<decimal> StoreExtraCost { get; set; }
        public static decimal TotalExtraCost { get; set; }  
    }
}
