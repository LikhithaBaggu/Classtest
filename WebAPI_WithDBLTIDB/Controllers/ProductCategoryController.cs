using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_WithDBLTIDB.Models;

namespace WebAPI_WithDBLTIDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
       
            private readonly AppDbContext _context;

            public ProductCategoryController(AppDbContext context)
            {
                _context = context;
            }
        [HttpGet]

       public ActionResult Get()
        {
            var data = _context.CatwiseProducts.FromSqlInterpolated($"dbo.SP_ProductCategory");
           return Ok(data);
        }

        [HttpGet]
        [Route("GetProductByCatId/{id:int}")]
        public ActionResult GetProductByCatId(int id)
        {
            var data = _context.CatwiseProducts.FromSqlInterpolated($"dbo.SP_ProductByCatId {id}");
            return Ok(data);

        }
        

    }
}


