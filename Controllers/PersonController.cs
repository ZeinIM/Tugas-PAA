using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PercobaanApi1.Models;
namespace PercobaanApi1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("api/person")]
        public ActionResult<Person> GetPersonbyId(int id_person)
        {
            PersonContext context = new PersonContext();
            Person person = context.ListPerson().FirstOrDefault(p => p.id_person == id_person);
            if (person != null)
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
        }
    }
}