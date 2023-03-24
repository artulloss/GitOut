using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace GitOut.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(new
            {
                name = "Adam Tulloss"
            });
        }
    }
}
