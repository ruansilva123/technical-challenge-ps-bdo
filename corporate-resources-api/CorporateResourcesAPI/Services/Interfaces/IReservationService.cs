using CorporateResourcesAPI.Dtos;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Services.Interfaces.Common;

namespace CorporateResourcesAPI.Services.Interfaces
{
    public interface IReservationService : IBaseService<Reservation>
    {
        Task<List<ReservationDetailDto>> ListAll(ReservationFilterDto filters);

        Task Create(NewReservationDto reservation);
    }
}
