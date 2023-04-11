using System;
using System.Collections.Generic;

namespace TicketBookingAPI.Models
{
    public partial class ShowTime
    {
        public ShowTime()
        {
            Bookings = new HashSet<Booking>();
        }

        public int ShowTimeId { get; set; }
        public int SeatId { get; set; }
        public TimeSpan ShowTime1 { get; set; }

        public virtual Seat Seat { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
