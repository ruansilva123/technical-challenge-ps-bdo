using Microsoft.AspNetCore.Mvc;

namespace CorporateResourcesAPI.Dtos
{
    public class ReservationFilterDto
    {
        public string? Item {  get; set; }
        public string? Category {  get; set; }
        public string? Responsible {  get; set; }
        public DateTime? StartDate {  get; set; }
        public  DateTime? EndDate { get; set; }
    }
}
