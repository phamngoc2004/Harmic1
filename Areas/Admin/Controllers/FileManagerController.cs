using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace Harmic.Areas.Admin.Controllers
{
    public class FileManagerController : Controller
    {
        [Area("Admin")]
        [Route("/Admin/file-manager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
