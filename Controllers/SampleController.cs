using AspectCoreIssue.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspectCoreIssue.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _service;

        public SampleController(ISampleService service)
        {
            _service = service;
        }

        [HttpGet]
        public string Index() => _service.Get("");
    }
}
