using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Resources.Models;
using System.Text.Json.Serialization;

namespace CorporateResources.Domain.Reservations.Models
{
    public class Reservation : BaseModel
    {
        public string Responsible { get; set; } = string.Empty;

        public DateTime StartReservation { get; set; }

        public DateTime EndReservation { get; set; }

        public int ResourceId { get; set; }

        [JsonIgnore]
        public Resource Resource { get; set; }
    }
}
