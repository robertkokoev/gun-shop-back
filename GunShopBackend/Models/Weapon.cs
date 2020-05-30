namespace GunShopBackend.Models
{
    public class Weapon
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public int ManufacturerId { get; set; }
        public string Type { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public int Capacity { get; set; }
        public string Caliber { get; set; }
        public int BulletSpeed { get; set; }
        public string Images { get; set; }
    }
}
