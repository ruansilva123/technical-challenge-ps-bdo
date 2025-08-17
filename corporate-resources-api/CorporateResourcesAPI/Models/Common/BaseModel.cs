namespace CorporateResourcesAPI.Models.Commom
{
    public class BaseModel
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public DateTime UpdateDate { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;
    }
}
