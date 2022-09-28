using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    //Class - Device
    public class DeviceRepository : GenericRepository<Device>, IDevicesRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {

        }

    }
}
