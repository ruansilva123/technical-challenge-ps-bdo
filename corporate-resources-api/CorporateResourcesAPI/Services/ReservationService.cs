using CorporateResourcesAPI.Dtos;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Repositories.Interfaces;
using CorporateResourcesAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CorporateResourcesAPI.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<Reservation> Create(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> ListAll()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> SearchById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ReservationDetailDto>> ListAll(ReservationFilterDto Filters)
        {
            var query = _reservationRepository.GetAll();

            if (!string.IsNullOrEmpty(Filters.Item))
            {
                query = query.Where(reservation => reservation.Resource.Name == Filters.Item);
            }

            if (!string.IsNullOrEmpty(Filters.Category))
            {
                query = query.Where(reservation => reservation.Resource.Category.Name == Filters.Category);
            }

            if (!string.IsNullOrEmpty(Filters.Responsible))
            {
                query = query.Where(reservation => reservation.Responsible == Filters.Responsible);
            }

            if (Filters.StartDate.HasValue && Filters.EndDate.HasValue)
            {
                query = query.Where(reservation => reservation.StartReservation >= Filters.StartDate && reservation.EndReservation <= reservation.EndReservation);
            }

            return query.Select(reservation => new ReservationDetailDto
            {
                ResourceName = reservation.Resource.Name,
                ResourceDescription = reservation.Resource.Description,
                ResourceCategory = reservation.Resource.Category.Name,
                ResourceCategoryDescription = reservation.Resource.Category.Description,
                City = reservation.Resource.Location.City,
                State = reservation.Resource.Location.State,
                Country = reservation.Resource.Location.Country,
                Responsible = reservation.Responsible,
                StartReservation = reservation.StartReservation,
                EndReservation = reservation.EndReservation,
                LoanDays = 0
            }).AsNoTracking().ToList();
        }
    }
}
