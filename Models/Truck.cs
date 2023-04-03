using TrucksCRUD.Data;

namespace TrucksCRUD.Models
{
    public class Truck
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
