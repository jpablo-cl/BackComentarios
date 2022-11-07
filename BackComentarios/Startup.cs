using Microsoft.EntityFrameworkCore;

namespace BackComentarios
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // ...
            string PostgresqlConnection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AplicationDbContext>(options => 
            options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));
        }

        public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
        {
            // ...
        }
    }
}
