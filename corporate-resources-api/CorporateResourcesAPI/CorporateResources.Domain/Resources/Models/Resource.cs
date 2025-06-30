using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Locations.Models;
using CorporateResources.Domain.Reservations.Models;
using CorporateResources.Domain.ResourceCategories.Models;

namespace CorporateResources.Domain.Resources.Models
{
    public class Resource : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public int CategoryId { get; set; }

        public ResourceCategory Category { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
