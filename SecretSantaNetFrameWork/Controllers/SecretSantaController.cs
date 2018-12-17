﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace SecretSantaNetFrameWork.Controllers
{
    public class SecretSantaController : ApiController
    {
        public HttpResponseMessage Get(string name)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    name,
                    Encoding.UTF8,
                    "text/html"
                )
            };
        }


    }
}
