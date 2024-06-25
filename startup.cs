using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EstacionamientoService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Este método se utiliza para agregar servicios al contenedor.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(); // Agregar soporte para controladores API

            // Aquí podrías configurar servicios adicionales como logging, CORS, autenticación, etc.
        }

        // Este método se utiliza para configurar el pipeline de solicitud HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Página de error detallada en entorno de desarrollo
            }
            else
            {
                // En producción, manejar errores de manera diferente
                app.UseExceptionHandler("/error");
                app.UseHsts();
            }

            app.UseRouting(); // Habilitar enrutamiento

            // Middleware para permitir CORS (si es necesario)
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin();
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            app.UseAuthorization(); // Middleware para autorización

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers(); // Configurar endpoints para controladores API
            });
        }
    }
}