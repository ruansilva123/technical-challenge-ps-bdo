using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Resources.Models;

namespace CorporateResources.Domain.ResourceCategories.Models
{
    public class ResourceCategory : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Resource> Resources { get; set; }
    }
}
