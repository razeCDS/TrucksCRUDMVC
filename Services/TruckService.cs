using TrucksCRUD.Data;
using TrucksCRUD.Models;

namespace TrucksCRUD.Services
{
    public class TruckService
    {
        private readonly TrucksCRUDContext _context;

        public TruckService( TrucksCRUDContext context )
        {
            _context = context;
        }

        public List<Truck> FindAll()
        {
            return _context.Truck.ToList();
        }
    }
}
