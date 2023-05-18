using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    public class Exportingtk
    {
        public string  ExportTime { get; set; }
        public string MovieName { get; set; }
        public string SeatName { get; set; }
        public string  ShowTime { get; set; }
        public float TicketPrice { get; set; }
        public Exportingtk(string exportTime, string movieName, string seatName, string showTime, float ticketPrice)
        {
            ExportTime = exportTime;
            MovieName = movieName;
            SeatName = seatName;
            ShowTime = showTime;
            TicketPrice = ticketPrice;
        }
    }
}
