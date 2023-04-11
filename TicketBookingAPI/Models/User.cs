using System;
using System.Collections.Generic;

namespace TicketBookingAPI.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
            Payments = new HashSet<Payment>();
            Seats = new HashSet<Seat>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}
