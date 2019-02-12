using CLTeam.Backend;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CLTeam.WebUI
{
    public class Startup
    {
        public Startup()
        {
            
        }

        

        
        public void ConfigureServices(IServiceCollection services)
        {
            
            
            // This is using a process caused dependency injection which is WAY outside the scope of class but is
            //    how you do things in the dotnet web world. Also since the backing store is just a json file this is
            //    in NO way safe for multiple users. You would want to use a database or other external storage.
            var manager = new CLTeamManager();
            services.AddSingleton(manager);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc();
        }
    }
}