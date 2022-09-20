using ApplicationApp.Interfaces;
using ApplicationApp.OpenApp;
using Domain.Interface.Generics;
using Domain.Interface.InterfaceAnuncio;
using Domain.Interface.InterfaceCliente;
using Domain.Interface.InterfaceServices;
using Domain.Services;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Infrastructure.Repository.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebGestorImoveis
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ContextBase>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            

            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ContextBase>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            //INTERFACE E REPOSITORIO
            services.AddSingleton(typeof(IGenerics<>), typeof(RepositoryGenerics<>));
            services.AddSingleton<ICliente, RepositoryCliente>();
            services.AddSingleton<IAnuncio, RepositoryAnuncio>();

            // INTERFACE APLICAÇÂO
            services.AddSingleton<InterfaceClienteApp, AppCliente>();
            services.AddSingleton<InterfaceAnuncioApp, AppAnuncio>();

            //SERVIÇo DOMNIO 
            services.AddSingleton<IServiceCliente, ServiceCliente>();
            services.AddSingleton<IServiceAnuncio, ServiceAnuncio>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
