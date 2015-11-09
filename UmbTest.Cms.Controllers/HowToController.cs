using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbTest.Services;

namespace UmbTest.Cms.Controllers
{
    public class HowToController : BaseController
    {
        private readonly IHowToService _howToSvc;

        public HowToController(IHowToService howToSvc)
        {
            _howToSvc = howToSvc;
        }


    }
}
