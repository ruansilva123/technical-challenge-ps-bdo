using CorporateResourcesAPI.Dtos;
using CorporateResourcesAPI.Exceptions;
using CorporateResourcesAPI.Models;
using CorporateResourcesAPI.Repositories.Interfaces;
using CorporateResourcesAPI.Services.Interfaces;
using CorporateResourcesAPI.Validators;
using Microsoft.EntityFrameworkCore;

namespace CorporateResourcesAPI.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IResourceRepository _resourceRepository;

        public ReservationService(IReservationRepository reservationRepository, IResourceRepository resourceRepository)
        {
            _reservationRepository = reservationRepository;
            _resourceRepository = resourceRepository;
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

        public async Task<List<ReservationDetailDto>> ListAll(ReservationFilterDto filters)
        {
            var query = _reservationRepository.GetAll();

            if (!string.IsNullOrEmpty(filters.Item))
            {
                query = query.Where(reservation => reservation.Resource.Name == filters.Item);
            }

            if (!string.IsNullOrEmpty(filters.Category))
            {
                query = query.Where(reservation => reservation.Resource.Category.Name == filters.Category);
            }

            if (!string.IsNullOrEmpty(filters.Responsible))
            {
                query = query.Where(reservation => reservation.Responsible == filters.Responsible);
            }

            if (filters.StartDate.HasValue && filters.EndDate.HasValue)
            {
                query = query.Where(reservation => reservation.StartReservation >= filters.StartDate && reservation.EndReservation <= reservation.EndReservation);
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

        public async Task Create(NewReservationDto reservation)
        {
            ReservationValidator.ValidateReservationDate(reservation.StartReservation, reservation.EndReservation);
            ReservationValidator.ValidateMaxReservationTime(reservation.StartReservation, reservation.EndReservation);
            ReservationValidator.ValidateReservationPeriod(reservation.StartReservation, reservation.EndReservation);

            var resource = await _resourceRepository.GetByIdAsync(reservation.ResourceId);

            if (resource == null)
            {
                throw new BadRequestException(400, "Resource ID does not exists.");
            }

            var loans = _reservationRepository.GetAll()
                .Where(loan => loan.ResourceId == reservation.ResourceId
                    && loan.StartReservation >= reservation.StartReservation
                    && loan.EndReservation <= reservation.EndReservation)
                .AsNoTracking()
                .ToList();

            if (loans.Count() != 0)
            {
                throw new BadRequestException(400, "The product has already been reserved in the selected range.");
            }

            try
            {
                var newReservation = new Reservation()
                {
                    ResourceId = reservation.ResourceId,
                    StartReservation = reservation.StartReservation,
                    EndReservation = reservation.EndReservation,
                    Responsible = reservation.Responsible
                };

                await _reservationRepository.CreateAsync(newReservation);
            }
            catch
            {
                throw new InternalServerErrorException(500, "Error to create reservation. Try again later.");
            }
        }
    }
}
