using System;
using System.Collections.Generic;
using System.Linq;

namespace UdemyTestProject.Mocking
{
    public static class BookingHelper
    {
        public static string OverlappingBookingsExist(Booking booking, IBookingRepository repository)
        {
            if (booking.Status == "Cancelled")
                return string.Empty;


            var bookings = repository.GetActiveBookings(booking.Id);
            var overlappingBooking = bookings.FirstOrDefault(b => booking.ArrivalDate < b.DepartureDate
                                                                 && b.ArrivalDate < booking.DepartureDate);

            return overlappingBooking == null ? string.Empty : overlappingBooking.Reference;
        }
    }

    public class UnitOfWork
    {
        public IQueryable<Booking> Query<T>() => new List<Booking>().AsQueryable();
    }

    public class Booking
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get;  set; }
        public string Reference { get;  set; }
    }
}