using CorporateResourcesAPI.Models.Commom;

namespace CorporateResourcesAPI.Models
{
    public class Reservation : BaseModel
    {
        public string? Responsible { get; set; }

        public DateTime StartReservation { get; set; }

        public DateTime EndReservation { get; set; }

        public int ResourceId { get; set; }

        public Resource Resource { get; set; }
    }
}
