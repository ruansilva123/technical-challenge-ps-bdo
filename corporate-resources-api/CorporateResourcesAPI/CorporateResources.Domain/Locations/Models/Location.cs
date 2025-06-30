using CorporateResources.Domain.Cities.Models;
using CorporateResources.Domain.Common.BaseModel;
using CorporateResources.Domain.Countries.Models;
using CorporateResources.Domain.Resources.Models;
using CorporateResources.Domain.States.Models;

namespace CorporateResources.Domain.Locations.Models
{
    public class Location : BaseModel
    {
        public int CountryId { get; set; }

        public Country Country { get; set; }

        public int StateId { get; set; }

        public State State { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

        public ICollection<Resource> Resources { get; set; }
    }
}
