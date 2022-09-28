using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    //Class - Zone
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {

        }

    }
}
