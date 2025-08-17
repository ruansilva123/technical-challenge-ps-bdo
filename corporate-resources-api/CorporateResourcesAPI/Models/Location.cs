using CorporateResourcesAPI.Models.Commom;

namespace CorporateResourcesAPI.Models
{
    public class Location : BaseModel
    {
        public string? City { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
