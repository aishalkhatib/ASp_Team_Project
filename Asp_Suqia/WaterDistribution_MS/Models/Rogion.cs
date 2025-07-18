namespace WaterDistribution_MS.Models
{
    public class Rogion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //العلاقة مع الزبائن
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public ICollection<TankArea> TankAreas { get; set; } = new List<TankArea>();
    }
}
