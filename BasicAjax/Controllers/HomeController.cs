using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{

    public class Reasonable
    {
        public string StringProp { get; set; }
        public int NumberProp { get; set; }
    }

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var x = new Reasonable() 
                {
                    StringProp = "call me ",
                    NumberProp = 123

                };
            return View(x);
        }

        public ActionResult SomeAction()
        {
            var x = new Reasonable()
            {
                StringProp = "call me ",
                NumberProp = 123

            };
            return View(x);
        }

        [HttpPost]
        public JsonResult SomeAction(Reasonable obj)
        {
            
            return Json(
                new
                    {
                        asdf="lala"
                    }
                );
        }
    }
}
