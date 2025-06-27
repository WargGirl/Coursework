using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Coursework.Utils.Enums;

namespace Coursework.Models
{

    public class Room
    {
        public string RoomId { get; set; } = Guid.NewGuid().ToString();
        public string Number { get; set; }
        public RoomType Type { get; set; }
        public List<BedConfiguration> BedConfigurations { get; set; } = new List<BedConfiguration>();
        public decimal Price { get; set; }
        public RoomStatus Status { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasKitchen { get; set; }
        public bool IsSmokingAllowed { get; set; }
        public bool IsPetFriendly { get; set; }
        public double SquareFootage { get; set; }
        public RoomView View { get; set; }
        public int Floor { get; set; }
        public List<string> OccupantGuestIds { get; set; } = new List<string>();
        [JsonIgnore]
        public int CalculatedCapacity
        {
            get
            {
                int totalCapacity = 0;
                foreach (var config in BedConfigurations)
                {
                    switch (config.Type)
                    {
                        case BedType.King: totalCapacity += config.Quantity * 2; break;
                        case BedType.Queen: totalCapacity += config.Quantity * 2; break;
                        case BedType.Double: totalCapacity += config.Quantity * 2; break;
                        case BedType.Twin: totalCapacity += config.Quantity * 1; break;
                        case BedType.SofaBed: totalCapacity += config.Quantity * 1; break;
                        case BedType.BunkBeds: totalCapacity += config.Quantity * 2; break;
                        default: break;
                    }
                }
                return totalCapacity;
            }
        }
        public class BedConfiguration
        {
            public BedType Type { get; set; }
            public int Quantity { get; set; }

            public BedConfiguration(BedType type, int quantity)
            {
                Type = type;
                Quantity = quantity;
            }

            public BedConfiguration() { }

            public override string ToString()
            {
                return $"{Quantity} x {Type} Bed(s)";
            }
        }
    }
}
