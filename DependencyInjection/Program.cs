
using DependencyInjection.Services;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Registering services
            builder.Services.AddTransient<IMyTransientService, MyTransientService>();

            builder.Services.AddScoped<IMyScopedService, MyScopedService>();

            builder.Services.AddSingleton<IMySingletonService, MySingletonService>();




            builder.Services.AddScoped<ITestService, TestService>();
            builder.Services.AddScoped<ITestService2, TestService2>();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
