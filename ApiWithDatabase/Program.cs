
using ApiWithDatabase.Controllers;
using EntityFrameworkProject.Database;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace ApiWithDatabase
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
            builder.Services.AddDbContext<BookContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));




            //builder.Logging.AddJsonConsole(options =>
            //{
            //    options.IncludeScopes = false;
            //    options.TimestampFormat = "HH:mm:ss ";
            //    options.JsonWriterOptions = new JsonWriterOptions
            //    {
            //        Indented = true
            //    };
            //});

            var app = builder.Build();

            if (app.Environment.IsProduction())
            {
                var db = app.Services.GetService<BookContext>();

                db.Database.Migrate();
            }

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
