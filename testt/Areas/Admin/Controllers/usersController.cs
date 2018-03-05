using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testt.Areas.Admin.Controllers
{
    public class usersController : Controller
    {
        // GET: Admin/users
        public ActionResult Index()
        {
            return Content("user");
        }
    }
}