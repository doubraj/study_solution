using Microsoft.EntityFrameworkCore;
using webapi.Data;

namespace webapi.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        // TODO: Get all
        // TODO: Get all v2 (support for pagination)
        // TODO: Get one by ID
        // TODO: Update one by ID
    }
}