using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalProject.WebAPI.DataAccess.Context;
using TraversalProject.WebAPI.DataAccess.Entities;

namespace TraversalProject.WebAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        private readonly ApiContext _apiContext;

        public VisitorController(ApiContext apiContext)
        {
            _apiContext = apiContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _apiContext.Visitors.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddVisitor(Visitor visitor)
        {
            _apiContext.Visitors.Add(visitor);
            _apiContext.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVisitor(Visitor visitor)
        {
            var values = _apiContext.Visitors.Find(visitor.VisitorId);
            values.Name = visitor.Name;
            values.Surname = visitor.Surname;
            values.City = visitor.City;
            values.Country = visitor.Country;
            values.Email = visitor.Email;
            _apiContext.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVisitor(int id)
        {
            var values = _apiContext.Visitors.Find(id);
            _apiContext.Visitors.Remove(values);
            _apiContext.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetVisitor(int id)
        {
            var values = _apiContext.Visitors.Find(id);
            return Ok(values);
        }
    }
}
