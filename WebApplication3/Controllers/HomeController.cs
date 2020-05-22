using modelsTraining2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelsTraining2.Controllers
{
    public class investmenController : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.ActionResult Show()
        {
            investmentContext db = new investmentContext();
            return View(db.Вложения_к_обращению);
        }
    }
}