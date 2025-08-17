namespace CorporateResourcesAPI.Dtos
{
    public class ReservationDetailDto
    {
        public string? ResourceName { get; set; }
        public string? ResourceDescription { get; set; }
        public string? ResourceCategory { get; set; }
        public string? ResourceCategoryDescription { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Responsible { get; set; }
        public DateTime? StartReservation { get; set; }
        public DateTime? EndReservation { get; set; }
        public int? LoanDays {  get; set; }
    }
}
