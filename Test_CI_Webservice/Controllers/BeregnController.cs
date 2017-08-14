using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TEST_CI;

namespace Test_CI_Webservice.Controllers
{
    //this is a comment from skype
    public class BeregnController : ApiController
    {

        // GET api/values
        public bool Get(int tal)
        {
            return Beregn.ErNulOgMindre(tal);
        }


    }
}
