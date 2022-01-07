using Commander.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;

namespace Commander
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Dependency injection. Object movement. How to manipulate an object from/to where.
        public void ConfigureServices(IServiceCollection services)
        {
            //string dbConnectionString = Configuration.GetConnectionString("CommanderConnection");
            //services.AddDbContext<CommanderContext>(opt => opt.UseMySql(dbConnectionString, ServerVersion.AutoDetect(dbConnectionString)));

            services.AddControllers().AddNewtonsoftJson(s => { s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //## mock version ##  when ICommanderRepo is called, respond with McokCommanderRepo implementation
            services.AddScoped<ICommanderRepo, MockCommanderRepo>(); // AddScoped -> instance created once per client request 
            //## Real sql connection version ##
            //services.AddScoped<ICommanderRepo, SqlCommanderRepo>(); 

        }

        // HTTP behaiviour. 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
