using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Shop.Models;

namespace Shop.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
       // private readonly IUnitOfWork _unitOfWork;

        public HomeController(/*IUnitOfWork unitOfWork*/)
        {
            // _unitOfWork = unitOfWork;
    
        }

        public ActionResult Index()
        {
         //   var d = _unitOfWork.ProductRepository.GetTopProductsByCost(1);
            ViewBag.Title = "Home Page";
            ApplicationDbContext db = new ApplicationDbContext();
            db.Roles.Add(new IdentityRole() { Name = "admin" });
            db.SaveChanges();
            return View();
        }
    }
}
