namespace aspnet_app.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int ServiceId { get; set; }
        public int EmployeeId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public TransactionStatus Status { get; set; } = TransactionStatus.New;
    }
}
