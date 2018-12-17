using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SecretSantaNetFrameWork.Controllers
{
    public class SecretSantaController : ApiController
    {
        public string Get(string lastName)
        {
            return "value";
        }
    }
}
