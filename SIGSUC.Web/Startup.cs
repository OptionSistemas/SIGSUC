using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using SIGSUC.DAL.Context;
using SIGSUC.Domain.Interfaces;
using SIGSUC.DAL.Repository.Common;

namespace SIGSUC.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("sigsuc.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            var connectionString = Configuration.GetConnectionString("SIGSUCDB");
            services.AddDbContext<SIGSUCContext>(option =>
                                                        option.UseSqlServer(connectionString,
                                                                            m => m.MigrationsAssembly("SIGSUC.DAL")));
            services.AddDefaultIdentity<IdentityUser>()
                 .AddEntityFrameworkStores<SIGSUCContext>();


            

            services.AddScoped<IContinenteRepository, ContinenteRepository>();
            services.AddScoped<IPaisRepository, PaisRepository>();
            services.AddScoped<IUFRepository, UFRepository>();
            services.AddScoped<IRegiaoRepository, RegiaoRepository>();

            services.AddFluentValidation();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles(); // deve ser antes do UseRouting()

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapAreaControllerRoute("Admin", "Admin", "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("Common", "Common", "Common/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
