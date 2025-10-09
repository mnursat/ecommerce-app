namespace EcommerceAppBackend.API.RequestPipeline;

using EcommerceAppBackend.API.Persistence.Database;
using Microsoft.EntityFrameworkCore;

public static class WebApplicationExtensions
{
    public static WebApplication ApplyMigrations(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<EcommerceAppDbContext>();
            db.Database.Migrate();
        }

        return app;
    }
}
