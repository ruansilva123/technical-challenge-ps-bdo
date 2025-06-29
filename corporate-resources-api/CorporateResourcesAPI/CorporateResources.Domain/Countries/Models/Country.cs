using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Locations.Models;

namespace CorporateResources.Domain.Countries.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Location> Locations { get; set; }
    }
}
