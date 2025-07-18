namespace WaterDistribution_MS.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal price { get; set; }
        public double capacity { get; set; }
        //العلاقة مع المناطق
        public ICollection<TankArea> tankAreas { get; set; } = new List<TankArea>();
        //مع الطلبات
        public ICollection<Order> orders { get; set; } = new List<Order>();
    }
}
