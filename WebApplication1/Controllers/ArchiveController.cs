using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveController : ControllerBase
    {
        private readonly ArchiveRepository archiveRepository;

        [HttpGet]
        public ActionResult<string[]> Get()
        {
            string[] directories = ; 
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
