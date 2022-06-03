namespace DoubleV.Api
{
    public static class Startup
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
     
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings:ConnectionString").Value));
            builder.Services.AddSwaggerGen();


     
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyHeader();
                    config.AllowAnyOrigin();
                });
            });

            return builder.Build();
        }

        public static WebApplication Configure(this WebApplication app)
        {
            // Habilitar el middleware para servir el documento
            // JSON generado y la interfaz UI de Swagger en el
            // ambiente de desarrollo.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

 

            // Agregar el Middleware CORS
            app.UseCors();
       

            return app;
        }
    }
}
