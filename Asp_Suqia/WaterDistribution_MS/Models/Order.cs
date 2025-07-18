namespace WaterDistribution_MS.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int time {  get; set; }
        public int quantity { get; set; }
        public string stat { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int TankId { get; set; }
        public Tank Tank { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

    }
}
