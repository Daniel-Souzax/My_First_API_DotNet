using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Entities;

namespace MyFirstAPI.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {

        var laptop = new Laptop();

        var model = laptop.GetBrand();  

        return Ok(model);
    }
}
