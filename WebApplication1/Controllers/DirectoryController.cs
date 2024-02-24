using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult<DirectoryModel> Add([FromBody] DirectoryModel directoryModel)
        {
            Directory.CreateDirectory($"C:\\Users\\ricar\\OneDrive\\Documentos\\Estudo\\C#\\WebApplication1\\_Directories\\{directoryModel.Name}");
            return Ok(directoryModel);
        }
    }
}
