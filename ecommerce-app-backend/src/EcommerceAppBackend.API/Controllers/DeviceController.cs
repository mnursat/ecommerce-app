namespace EcommerceAppBackend.API.Controllers;

using EcommerceAppBackend.API.Models;
using EcommerceAppBackend.API.Services;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    private readonly DevicesService _devicesService;

    public DeviceController(DevicesService devicesService)
    {
        _devicesService = devicesService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDevicesAsync()
    {
        var devices = await _devicesService.GetAllAsync();

        if (devices is null)
        {
            return BadRequest();
        }

        return Ok(devices);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Device device)
    {
        await _devicesService.AddAsync(device);
        return Created();
    }
}
