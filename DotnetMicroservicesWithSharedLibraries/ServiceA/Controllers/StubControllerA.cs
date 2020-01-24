using Microsoft.AspNetCore.Mvc;
using SharedLibrary1;

namespace ServiceA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StubController : ControllerBase
    {
        private readonly CommonLogic _commonLogic = new CommonLogic();

        [HttpGet]
        public string GetData()
        {
            return _commonLogic.DoIt();
        }
    }
}
