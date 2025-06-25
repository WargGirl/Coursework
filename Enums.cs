using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
    public class Enums
    {
        //Overall
        public static void PopulateFilterComboBox<TEnum>(ComboBox comboBox, string allOptionText) where TEnum : Enum
        {
            var values = Enum.GetNames(typeof(TEnum)).ToList();
            values.Insert(0, allOptionText);
            comboBox.DataSource = values;
            comboBox.SelectedIndex = 0;
        }
        public enum Gender
        {
            Male,
            Female,
            Other
        }

        //Guest
        public enum GuestStatus
        {
            InHotel,
            NotInHotel,
            Booked,
            InHotelCheckOutDay,
            BookedCheckIn
        }

        //Staff
        public enum StaffEmploymentStatus
        {
            Active,
            OnLeave,
            Terminated
        }
        public enum StaffProfession
        {
            Receptionist,
            Cleaner,
            Manager,
            Cook,
            Security
        }

        //Room
        public enum RoomStatus
        {
            Available,
            Occupied,
            Cleaning,
            Maintenance
        }
        public enum BedType
        {
            King,
            Queen,
            Double,
            Twin,
            SofaBed,
            BunkBeds,
        }
        public enum RoomView
        {
            CityView,
            OceanView,
            PoolView,
            GardenView,
            NoView,
            MountainView,
            LakeView,
            RiverView,
            CourtyardView
        }
        public enum RoomType
        {
            Standard,
            Deluxe,
            Suite,
            Family,
            Executive,
            Studio,
            Penthouse,
            Accessible
        }
    }
}
