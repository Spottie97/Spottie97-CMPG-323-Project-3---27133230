using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    //Class - Category
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ConnectedOfficeContext context) : base(context)
        {

        }
    }
}
