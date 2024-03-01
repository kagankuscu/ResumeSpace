namespace KaganKuscu.Model.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public Guid guid { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
