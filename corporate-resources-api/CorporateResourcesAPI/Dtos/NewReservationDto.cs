namespace CorporateResourcesAPI.Dtos
{
    public class NewReservationDto
    {
        public int ResourceId { get; set; }
        public DateTime StartReservation {  get; set; }
        public DateTime EndReservation { get; set; }
        public string Responsible { get; set; }
    }
}
