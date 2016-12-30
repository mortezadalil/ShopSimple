using System.Web.Mvc;
using Shop.Models.Northwind;

namespace Shop.Controllers
{
   // [Authorize]
    public class HomeController : Controller
    {
       private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
         //   var d = _unitOfWork.ProductRepository.GetTopProductsByCost(1);
            //_unitOfWork.Applicationroles.Add(new ApplicationRole() { Name = "user"});
           // _unitOfWork.Applicationusers.Add(new ApplicationUser() {MobileNumberConfirmed = false,IsActive = true,Email = "m@m.com",EmailConfirmed = true,PhoneNumberConfirmed = true,TwoFactorEnabled = false,LockoutEnabled = false,AccessFailedCount = 0});
          //  _unitOfWork.Save();
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
