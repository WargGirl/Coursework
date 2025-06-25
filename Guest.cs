using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Coursework.Enums;

namespace Coursework
{
    public class Guest
    {
        public string GuestId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RoomNumber { get; set; }
        public string PhotoBase64 { get; set; }
        public Gender GuestGender { get; set; }
        public bool IsVIP { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CheckInDate { get; set; } = DateTime.MinValue;
        public DateTime CheckOutDate { get; set; } = DateTime.MinValue;
        public string AdditionalInfo { get; set; } = "";
        public bool inHotelCheck { get; set; } = false;
        public Room AssignedRoom { get; set; } = null;

        [JsonIgnore]
        public GuestStatus InHotelStatus
        {
            get
            {
                DateTime today = DateTime.Today.Date;

                if (string.IsNullOrWhiteSpace(RoomNumber) || CheckInDate == DateTime.MinValue || CheckOutDate == DateTime.MinValue)
                {
                    return GuestStatus.NotInHotel;
                }

                if (today >= CheckInDate.Date && today < CheckOutDate.Date && inHotelCheck)
                {
                    return GuestStatus.InHotel;
                }
                else if (today == CheckOutDate.Date)
                {
                    return GuestStatus.InHotelCheckOutDay;
                }
                else if (today >= CheckInDate.Date && !inHotelCheck)
                {
                    return GuestStatus.BookedCheckIn;
                }
                else if (today > CheckOutDate.Date)
                {
                    return GuestStatus.NotInHotel; 
                }
                else
                {
                    return GuestStatus.Booked;
                }

                return GuestStatus.NotInHotel;
            }
        }

        [JsonIgnore]
        public int Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DateOfBirth.Year;

                if (DateOfBirth.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;
            }
        }
    }
}
