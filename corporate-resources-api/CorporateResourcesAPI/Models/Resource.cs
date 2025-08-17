using CorporateResourcesAPI.Models.Commom;

namespace CorporateResourcesAPI.Models
{
    public class Resource : BaseModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public int LocationId { get; set; }

        public Location? Location { get; set; }

        public int CategoryId { get; set; }

        public ResourceCategory? Category { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
