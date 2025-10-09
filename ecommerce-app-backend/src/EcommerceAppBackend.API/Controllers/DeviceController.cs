namespace EcommerceAppBackend.API.Controllers;

using EcommerceAppBackend.API.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    [HttpGet]
    public async Task<List<Device>> GetDevicesAsync()
    {
        var devices = new List<Device>();


        return devices;
    }
}
