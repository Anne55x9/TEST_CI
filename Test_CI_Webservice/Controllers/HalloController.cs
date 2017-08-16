using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Test_CI_Webservice.Controllers
{
    public class HalloController : ApiController
    {

        public string Get()
        {
            return "Hallo EASJ";

        }

    }
}
