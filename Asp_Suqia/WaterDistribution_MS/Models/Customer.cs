namespace WaterDistribution_MS.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String phone {  get; set; }

        // العلاقة مع المنطقة \منطقة لكل زبون
        public int RoginId { get; set; }
        public Rogion Rogion { get; set; }
        //العلاقة مع الطلبات
        public ICollection<Order> Orders { get; set; } = new List<Order>();

    }
}
