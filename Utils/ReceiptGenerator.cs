using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coursework.Models;

namespace Coursework.Utils
{
    public static class ReceiptGenerator
    {
        public static void GenerateCheckInReceipt(Guest guest, Room room, string filePath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- HOTEL RECEIPT: CHECK-IN ---");
            sb.AppendLine($"Date: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- GUEST DETAILS ---");
            sb.AppendLine($"Guest Name: {guest.Name} {guest.Surname}");
            sb.AppendLine($"Passport ID: {guest.Passport}");
            sb.AppendLine($"Phone: {guest.Phone}");
            sb.AppendLine($"VIP Status: {(guest.IsVIP ? "Yes" : "No")}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- ROOM DETAILS ---");
            sb.AppendLine($"Room Number: {room.Number}");
            sb.AppendLine($"Room Type: {room.Type}");
            sb.AppendLine($"Room Capacity: {room.CalculatedCapacity} guests");
            sb.AppendLine($"Bed Configuration: {string.Join(", ", room.BedConfigurations.Select(b => b.ToString()))}");
            sb.AppendLine($"Daily Rate: {room.Price:C}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- BOOKING DETAILS ---");
            sb.AppendLine($"Check-in Date: {guest.CheckInDate.ToShortDateString()}");
            sb.AppendLine($"Check-out Date: {guest.CheckOutDate.ToShortDateString()}");
            TimeSpan stayDuration = guest.CheckOutDate.Date - guest.CheckInDate.Date;
            int numberOfNights = (int)stayDuration.TotalDays;
            sb.AppendLine($"Number of Nights: {numberOfNights}");
            sb.AppendLine($"Estimated Total: {room.Price * numberOfNights:C}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\nThank you for choosing our hotel!");

            SaveReceiptToFile(sb.ToString(), filePath, $"CheckIn_Receipt_{guest.Surname}_{guest.RoomNumber}.txt");
        }

        public static void GenerateCheckOutReceipt(Guest guest, Room room)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- HOTEL RECEIPT: CHECK-OUT ---");
            sb.AppendLine($"Date: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- GUEST DETAILS ---");
            sb.AppendLine($"Guest Name: {guest.Name} {guest.Surname}");
            sb.AppendLine($"Passport ID: {guest.Passport}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- CHECK-OUT DETAILS ---");
            sb.AppendLine($"Room Number (Vacated): {room.Number}");
            sb.AppendLine($"Original Check-in Date: {guest.CheckInDate.ToShortDateString()}");
            TimeSpan stayDuration = DateTime.Today - guest.CheckInDate.Date;
            int numberOfNights = (int)stayDuration.TotalDays;
            sb.AppendLine($"Actual Check-out Date: {DateTime.Today.ToShortDateString()}");
            sb.AppendLine($"Total Amount Due/Paid: {room.Price * numberOfNights:C}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\nThank you for your stay! We hope to see you again.");

            SaveReceiptToFile(sb.ToString(), filePath: null, $"CheckOut_Receipt_{guest.Surname}_{room.Number}.txt");
        }

        public static void GenerateExtendStayReceipt(Guest guest, DateTime oldCheckOutDate, DateTime newCheckOutDate, Room room)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("--- HOTEL RECEIPT: EXTENDED STAY ---");
            sb.AppendLine($"Date: {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- GUEST DETAILS ---");
            sb.AppendLine($"Guest Name: {guest.Name} {guest.Surname}");
            sb.AppendLine($"Room Number: {guest.RoomNumber}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\n--- EXTENSION DETAILS ---");
            sb.AppendLine($"Original Check-out Date: {oldCheckOutDate.ToShortDateString()}");
            sb.AppendLine($"New Check-out Date: {newCheckOutDate.ToShortDateString()}");
            TimeSpan stayDuration = newCheckOutDate.Date - oldCheckOutDate.Date;
            int numberOfNights = (int)stayDuration.TotalDays;
            sb.AppendLine($"Additional Nights: {numberOfNights}");
            sb.AppendLine($"Estimated Additional Cost: {room.Price * numberOfNights:C}");
            sb.AppendLine("-----------------------------");
            sb.AppendLine("\nYour stay has been extended. Enjoy the rest of your visit!");

            SaveReceiptToFile(sb.ToString(), filePath: null, $"ExtendStay_Receipt_{guest.Surname}_{guest.RoomNumber}.txt");
        }

        private static void SaveReceiptToFile(string content, string filePath, string defaultFileName)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text File|*.txt|All Files|*.*";
            sfd.FileName = defaultFileName;
            sfd.Title = "Save Receipt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfd.FileName, content);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving receipt: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
