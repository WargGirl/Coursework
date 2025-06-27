using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Coursework.Utils.Enums;

namespace Coursework.Models
{

    public class Staff
    {
        public string StaffId { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public StaffProfession Profession { get; set; }
        public StaffEmploymentStatus EmploymentStatus { get; set; }
        public decimal Salary { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }
        public DateTime DateOfBirth { get; set; }
        public TimeSpan WorkStartTime { get; set; } = TimeSpan.FromHours(9);
        public TimeSpan WorkEndTime { get; set; } = TimeSpan.FromHours(17);
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
        [JsonIgnore]
        public bool IsCurrentlyWorking
        {
            get
            {
                if (EmploymentStatus != StaffEmploymentStatus.Active)
                {
                    return false;
                }
                TimeSpan currentTime = DateTime.Now.TimeOfDay;

                if (WorkStartTime <= WorkEndTime)
                {
                    return currentTime >= WorkStartTime && currentTime < WorkEndTime;
                }
                else
                {
                    return currentTime >= WorkStartTime || currentTime < WorkEndTime;
                }
            }
        }
        [JsonIgnore]
        public string WorkStatusDisplay
        {
            get
            {
                if (EmploymentStatus != StaffEmploymentStatus.Active)
                {
                    return EmploymentStatus.ToString();
                }

                if (IsCurrentlyWorking)
                {
                    return "Working now";
                }
                else
                {
                    return $"Off shift ({WorkStartTime:hh\\:mm}-{WorkEndTime:hh\\:mm})";
                }
            }
        }
    }
}
