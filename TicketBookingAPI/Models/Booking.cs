using System;
using System.Collections.Generic;

namespace TicketBookingAPI.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int TotalAmount { get; set; }
        public int UserId { get; set; }
        public int PaymentId { get; set; }
        public int SeatId { get; set; }
        public int ShowTimeId { get; set; }

        public virtual Payment Payment { get; set; } = null!;
        public virtual Seat Seat { get; set; } = null!;
        public virtual ShowTime ShowTime { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
