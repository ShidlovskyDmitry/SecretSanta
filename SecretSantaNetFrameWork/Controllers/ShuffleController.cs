using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SecretSantaNetFrameWork.Controllers
{
    public class ShuffleController : ApiController
    {
        // GET: Shuffle
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    "Shuffled!",
                    Encoding.UTF8,
                    "text/html"
                )
            };
        }
    }
}