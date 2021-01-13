using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ZMSProto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZMSProtoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAction()
        {
            return new string[] {"this", "is", "hard", "coded"};
        }
    }
}