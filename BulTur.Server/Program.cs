using BulTur.Server.Data;
using BulTur.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BulTur.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
                    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                });

            // Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database Connection
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<BulTurDbContext>(options => options.UseSqlServer(connectionString));

            // CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin", policy =>
                {
                    policy.WithOrigins("https://localhost:5173", "http://127.0.0.1:5500")
                          .AllowAnyHeader()
                          .AllowAnyMethod()
                          .AllowCredentials();
                });
            });

            // Identity
            builder.Services.AddIdentity<StaffAccount, IdentityRole>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<BulTurDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddAuthorization();

            var app = builder.Build();

            // Serve static files
            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Enable CORS
            app.UseCors("AllowSpecificOrigin");

            // Enable Swagger in development
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Enable HTTPS
            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            // Map Controllers
            app.MapControllers();

            // Fallback for React Frontend
            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
