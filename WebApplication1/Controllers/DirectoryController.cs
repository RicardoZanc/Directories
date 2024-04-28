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
        private readonly ILogger<DirectoryController> logger;

        public DirectoryController(ILogger<DirectoryController> logger) {
            this.logger = logger;
            directoryRepository = new DirectoryRepository();
        }

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            string[] directories = directoryRepository.GetDirectories(); 
            return Ok(directories);
        }

        [HttpPost]
        public ActionResult<DirectoryModel> Add([FromBody] DirectoryModel directoryModel)
        {
            directoryRepository.AddDirectory(directoryModel);
            return Ok(directoryModel);
        }

        //[HttpGet]
        //public ActionResult<string> tst() { 
        //    return Ok(directoryRepository.GetDirectories());
        //}
    }
}
