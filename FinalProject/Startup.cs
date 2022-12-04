
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;

namespace FinalProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerDocument();
            services.AddDbContext<FavGamesContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddDbContext<HobbiesContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddDbContext<MembersInfoContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddScoped<FavGamesContextDAO, FavGamesContextDAO>();
            services.AddScoped<HobbiesContextDAO, HobbiesContextDAO>();
            services.AddScoped<MembersInfoContextDAO, MembersInfoContextDAO>();
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FavGamesContext context)
        {
             if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOpenApi();
            app.UseSwaggerUi3();
            context.Database.Migrate();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
        }

    }
}

