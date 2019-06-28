using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using SIGSUC.DAL.Context;
using SIGSUC.DAL.Repository;
using SIGSUC.Domain.Entities.Common.Validations;
using SIGSUC.Domain.Interfaces;

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


            services
                    .AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                    // Maintain property names during serialization. See:
                    // https://github.com/aspnet/Announcements/issues/194
                    .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver())
                    .AddFluentValidation(fvc =>
                            fvc.RegisterValidatorsFromAssemblyContaining<ContinenteValidator>());
                            
            // Add Kendo UI services to the services container
            services.AddKendo();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
/*
            services.AddTransient<IContinenteRepository, ContinenteRepository>();
            services.AddTransient<IPaisRepository, PaisRepository>();
            services.AddTransient<IValidator<Pais>, PaisValidator>();
            services.AddTransient<IUFRepository, UFRepository>();
            services.AddTransient<IRegiaoRepository, RegiaoRepository>();
            */


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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


            app.UseAuthentication();

            /*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapAreaControllerRoute("Admin", "Admin", "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapAreaControllerRoute("Common", "Common", "Common/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            */
            app.UseMvc(routes =>
            {
                routes.MapAreaRoute(
                            name: "Admin",
                            areaName: "Admin",
                            template: "Admin/{controller=Home}/{action=Index}/{id?}");

                routes.MapAreaRoute(
                            name: "Common",
                            areaName: "Common",
                            template: "Common/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
