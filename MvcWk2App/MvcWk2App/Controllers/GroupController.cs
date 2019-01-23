using MvcWk2App.Models;
using MvcWk2App.Shared.Orchestrators;
using System.Web.Mvc;

namespace MvcWk2App.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentOrchestrator = new StudentOrchestrator();

            var model = new GroupModel
            {
                GroupNumber = 1,
                GroupName = "The winners",
                Students = studentOrchestrator.GetAllStudents()

            };

            return View(model);
        }
    }
}