using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Locations.Models;

namespace CorporateResources.Domain.Cities.Models
{
    public class City : BaseModel
    {
        public string Name { get; set; } = string.Empty;

        public Location Location { get; set; }
    }
}
