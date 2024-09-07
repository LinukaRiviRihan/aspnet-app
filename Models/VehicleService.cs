namespace aspnet_app.Models
{
    public class VehicleService
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
