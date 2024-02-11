using Microsoft.EntityFrameworkCore;
using SportsPro.Models;

namespace SportsPro
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // ...

            services.AddDbContext<SportsProContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("SportsProContext"))
                       .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            });

            services.AddControllersWithViews();

            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = true;
            });
        }

    }
}
