namespace EcommerceAppBackend.API.Persistence.Repositories;

using EcommerceAppBackend.API.Models;
using EcommerceAppBackend.API.Persistence.Database;
using Microsoft.EntityFrameworkCore;

public class DevicesRepository
{
    private readonly EcommerceAppDbContext _dbContext;

    public DevicesRepository(EcommerceAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Device device)
    {
        await _dbContext.Devices.AddAsync(device);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Device>> GetAllAsync()
    {
        return await _dbContext.Devices.ToListAsync();
    }
}
