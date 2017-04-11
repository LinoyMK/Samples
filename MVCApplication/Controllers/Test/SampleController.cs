using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MVCApplication.Controllers.Test
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult Index()
        {
            EmployeeViewModel empOj = new EmployeeViewModel() { Id = 1, IsVisible = true, Name = "Linoy" };

            return View(empOj);
        }

        public ActionResult Edit()
        {
            if (Session["test"] == null)
            {
                Session["test"] = "Hello";
            }

            ViewBag.MyData = "New Data";
            ViewData.Add("viewData1", 100000);
            TempData.Add("temp1", 100);

            return RedirectToAction("RedirectedAction");
        }

        public ActionResult RedirectedAction()
        {
            int data = (int)TempData["temp1"];
            var value = ViewBag.MyData;

            return RedirectToAction("RedirectedToSecondAction");
        }

        public ActionResult RedirectedToSecondAction()
        {
            int data = (int)TempData["temp1"];
            var value = ViewBag.MyData;

            return View();
        }
    }

    public class EmployeeViewModel
    {

        public int Id { get; set; }

        [Display(Name = "User Name")]
        public string Name { get; set; }

        public bool IsVisible { get; set; }

    }


}