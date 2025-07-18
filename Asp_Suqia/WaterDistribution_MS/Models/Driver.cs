namespace WaterDistribution_MS.Models
{
    public class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string work { get; set; }

        public ICollection<Order> orders { get; set; } = new List<Order>();
    }
}
