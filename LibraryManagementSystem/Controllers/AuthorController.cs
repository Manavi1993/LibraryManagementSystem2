using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}