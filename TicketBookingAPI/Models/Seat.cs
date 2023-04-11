using System;
using System.Collections.Generic;

namespace TicketBookingAPI.Models
{
    public partial class Seat
    {
        public Seat()
        {
            Bookings = new HashSet<Booking>();
            ShowTimes = new HashSet<ShowTime>();
        }

        public int SeatId { get; set; }
        public int UserId { get; set; }
        public int NumOfSeat { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<ShowTime> ShowTimes { get; set; }
    }
}
