using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Asp.netCoreCRUD.Controllers
{
    public class ToDoController : Controller
    {
        /*private readonly MvcTaskContext _context;

        public ToDoController(MvctaskContext context)
        {
            _context = context;
        }*/
        public IActionResult Index()
        {
            return View();
        }
    }
}
