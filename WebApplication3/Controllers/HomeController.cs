using modelsTraining2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace modelsTraining2.Controllers
{
    public class InvestmenController : Microsoft.AspNetCore.Mvc.Controller
    {
        public Microsoft.AspNetCore.Mvc.ActionResult Show()
        {
            InvestmentContext db = new InvestmentContext();
            return View(db.Вложения_к_обращению);
        }
    }
}