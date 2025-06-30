using CorporateResources.Exceptions;

namespace CorporateResources.Domain.Reservations.Validations
{
    public class HourValidation
    {
        public static void ValidateReservationDate(DateTime startDate, DateTime endDate)
        {
            if (startDate > endDate)
            {
                throw new BadRequestException("Invalid request! End date must be greater than start date.");
            }
        }

        public static void ValidateMaxReservationTime(DateTime startDate, DateTime endDate)
        {
            if ((endDate - startDate) > TimeSpan.FromHours(8))
            {
                throw new BadRequestException("The reservation time exceeded the permitted 8 hours.");
            }
        }

        public static void ValidateReservationPeriod(DateTime startDate, DateTime endDate)
        {
            TimeSpan startReservation = startDate.TimeOfDay;
            TimeSpan endReservation = endDate.TimeOfDay;

            TimeSpan startLimit = TimeSpan.FromHours(8);
            TimeSpan endLimit = TimeSpan.FromHours(18);

            bool startValid = startReservation >= startLimit && startReservation <= endLimit;
            bool endValid = endReservation >= startLimit && endReservation <= endLimit;

            if (!startValid || !endValid)
            {
                throw new BadRequestException("Invalid Request! The reservation period is from 08:00 to 18:00.");
            }
        }
    }
}
