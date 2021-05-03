using System;
using DesafioSoftPlan.Api.ApiServices;
using DesafioSoftPlan.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace DesafioSoftPlan.Api
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
            services.AddControllers();

            services.AddSwaggerGen(swaggerOptions => 
            {
                swaggerOptions.SwaggerDoc("DesafioSoftPlan", GetApiInfo());
            });

            services.AddTransient<TaxaDeJurosApiService>();
            services.AddTransient<JurosCompostosService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/DesafioSoftPlan/swagger.json", "Desafio Softplan");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private OpenApiInfo GetApiInfo()
        {
            return new OpenApiInfo()
            {
                Title = "Desafio Softplan",
                Version = "1.0",
                Description = "Api criada para o desafio Softplan.",
                Contact = new OpenApiContact()
                {
                    Name = "Stenio Nobres",
                    Url = new Uri("https://www.linkedin.com/in/stenionobres/")
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT License",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                }
            };
        }
    }
}
