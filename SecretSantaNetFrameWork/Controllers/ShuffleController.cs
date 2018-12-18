using SecretSantaNetFrameWork.Models;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace SecretSantaNetFrameWork.Controllers
{
    public class ShuffleController : ApiController
    {
        // GET: Shuffle
        public HttpResponseMessage Get()
        {
            SecretBox.Shuffle();
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