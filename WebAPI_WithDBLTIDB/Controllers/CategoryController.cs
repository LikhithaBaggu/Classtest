using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_WithDBLTIDB.Models;
using System.Linq;

namespace WebAPI_WithDBLTIDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public AppDbContext _context { get; }
        [HttpGet]
        public ActionResult Get()
        {
            var data = _context.Categories.ToList();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult get(int id)
        {
            var data = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            return Ok(data);
        }

        [HttpPost]
        public ActionResult post(Category newcategory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                _context.Categories.Add(newcategory);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpPut("{id}")]

        public ActionResult put(int? id, Category cat)

            {
                if (id == null)

                    return NotFound();

                else
                {
                    var data = _context.Categories.FirstOrDefault(c => c.CategoryId == id);

                    if (!ModelState.IsValid)

                        return BadRequest();

                    else

                        data.CategoryName = cat.CategoryName;
                    data.CategoryId = cat.CategoryId;
                    data.CategoryId = cat.CategoryId;



                    _context.SaveChanges();
                    return Ok();

                }


            }
        }
    }

