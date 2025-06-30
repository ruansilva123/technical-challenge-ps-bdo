using CorporateResources.Communication.Responses;
using CorporateResources.Domain.Reservations.Models;
using CorporateResources.Domain.Reservations.Repositories;
using CorporateResources.Domain.Reservations.Services;
using CorporateResources.Domain.Reservations.Validations;
using CorporateResources.Exceptions;

namespace CorporateResources.Application.Reservations.Services
{
    public class ReservationService : IReservationsService
    {
        private readonly IReservationsReporitory _reservationsReporitory;

        public ReservationService(IReservationsReporitory reservationsReporitory)
        {
            _reservationsReporitory = reservationsReporitory;
        }

        public async Task<GenericResponse<Reservation>> Create(Reservation entity)
        {
            HourValidation.ValidateReservationDate(entity.StartReservation, entity.EndReservation);
            HourValidation.ValidateMaxReservationTime(entity.StartReservation, entity.EndReservation);
            HourValidation.ValidateReservationPeriod(entity.StartReservation, entity.EndReservation);

            // validar se já foi agendado

            try
            {
                var reservation = await _reservationsReporitory.CreateAsync(entity);

                GenericResponse<Reservation> response = new GenericResponse<Reservation>();
                response.Entity = reservation;
                return response;
            }
            catch (Exception)
            {
                throw new InternalServerErrorException("Error to create reservation. Try again later.");
            }
        }

        public async Task<GenericResponse<List<Reservation>>> ListAll()
        {
            throw new NotImplementedException();
        }

        public async Task<GenericResponse<List<Reservation>>> SearchById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
