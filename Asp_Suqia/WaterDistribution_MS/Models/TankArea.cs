namespace WaterDistribution_MS.Models
{
    public class TankArea
    {
        public int TankId { get; set; }
        public Tank Tank { get; set; }

        public int RogionId { get; set; }
        public Rogion Rogion { get; set; }
    }
}
