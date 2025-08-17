using CorporateResourcesAPI.Models.Commom;

namespace CorporateResourcesAPI.Models
{
    public class ResourceCategory : BaseModel
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
