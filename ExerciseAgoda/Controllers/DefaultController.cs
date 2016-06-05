using ExerciseAgoda.Repository;
using System.Web.Mvc;

namespace ExerciseAgoda.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHotelRepository repository;
        public DefaultController(IHotelRepository repository)
        {
            this.repository = repository;
        }
        
        [HttpPost]
        public ActionResult getHotel()
        {
            return Json(repository.fetchHotels());
        }
        
        public ActionResult Static()
        {
            return View("~/Views/Default/Index.cshtml", repository.fetchHotels());
        }

        public ActionResult Ajax()
        {
            return View();
        }

    }
}