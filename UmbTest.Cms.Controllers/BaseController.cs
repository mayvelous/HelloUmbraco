using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbTest.Models;

namespace UmbTest.Cms.Controllers
{
    public class BaseController : RenderMvcController
    {
        protected ViewResult View(BaseModel model)
        {
            return View(null, model);
        }

        protected ViewResult View(string view, BaseModel model)
        {
            //TODO

            return base.View(model);
        }
    }
}
