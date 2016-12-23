using System.Web.Mvc;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IUnitOfWork _unitOfWork;

        //public HomeController(IUnitOfWork unitOfWork)
        //{
        //    _unitOfWork = unitOfWork;
        //}

        public ActionResult Index()
        {
            //  var d=_unitOfWork.ProductRepository.GetTopProductsByCost(1);
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
