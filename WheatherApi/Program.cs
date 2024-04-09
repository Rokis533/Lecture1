
using Microsoft.Extensions.Options;

namespace WheatherApi
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
            //builder.Services.AddHttpClient<ExternalApiService>((serviceProvider, client) =>
            //{
            //    var settings = serviceProvider.GetRequiredService<IOptions<ApiSetting>>().Value;

            //    client.DefaultRequestHeaders.Add("Accept", "application/json");
            //    client.DefaultRequestHeaders.Add("Authorization", settings.ApiKey);
            //    client.BaseAddress = new Uri("htttps://google.com/api");
            //})
            //.ConfigurePrimaryHttpMessageHandler(() =>
            //{
            //    return new SocketsHttpHandler()
            //    {
            //        PooledConnectionLifetime = TimeSpan.FromMinutes(10),
            //    };
            //});



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
