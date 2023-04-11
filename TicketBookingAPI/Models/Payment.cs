using System;
using System.Collections.Generic;

namespace TicketBookingAPI.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Bookings = new HashSet<Booking>();
        }

        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public string? Type { get; set; }
        public string? PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
