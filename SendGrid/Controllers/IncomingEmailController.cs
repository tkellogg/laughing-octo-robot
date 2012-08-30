using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SendGrid.Controllers
{
    public class IncomingEmailController : ApiController
    {
        public string Get()
        {
            return "GET";
        }
    }
}