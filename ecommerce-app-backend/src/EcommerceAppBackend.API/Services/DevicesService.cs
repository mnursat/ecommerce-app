namespace EcommerceAppBackend.API.Services;

using EcommerceAppBackend.API.Models;
using EcommerceAppBackend.API.Persistence.Repositories;

public class DevicesService
{
    private readonly DevicesRepository _devicesRepository;

    public DevicesService(DevicesRepository devicesRepository)
    {
        _devicesRepository = devicesRepository;
    }

    public async Task AddAsync(Device device)
    {
        await _devicesRepository.AddAsync(device);
    }

    public async Task<List<Device>> GetAllAsync()
    {
        var devices = await _devicesRepository.GetAllAsync();
        if (devices == null)
        {
            return null;
        }

        return devices;
    }
}
