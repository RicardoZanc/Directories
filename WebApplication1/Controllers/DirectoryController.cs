using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        private readonly DirectoryRepository directoryRepository;

        public DirectoryController() { 
            directoryRepository = new DirectoryRepository();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<DirectoryModel> Add([FromBody] DirectoryModel directoryModel)
        {
            directoryRepository.AddDirectory(directoryModel);
            return Ok(directoryModel);
        }

        [HttpGet]
        public ActionResult<string> tst() { 
            return Ok(directoryRepository.GetDirectories());
        }
    }
}
