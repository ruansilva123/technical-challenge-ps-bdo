using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Resources.Models;

namespace CorporateResources.Domain.Reservations.Models
{
    public class Reservation : BaseModel
    {
        public DateTime StartReservation { get; set; }

        public DateTime EndReservation { get; set; }

        public Resource Resource { get; set; }
    }
}
