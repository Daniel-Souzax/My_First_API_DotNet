using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string author { get; set; } = "dan";
}
