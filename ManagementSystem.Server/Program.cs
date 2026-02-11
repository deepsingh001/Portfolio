using Microsoft.EntityFrameworkCore;
using ManagementSystem.Server.Data;
using Microsoft.AspNetCore.Builder;
using ManagementSystem.Server.Interfaces;
using ManagementSystem.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Services
builder.Services.AddControllers();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<IContactService, ContactService>();

// 🔹 Swagger (ONLY ONE system)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// 🔹 CORS (agar Angular same project me hai to optional)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// 🔹 Swagger (Development only)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 🔹 Static files for Angular
app.UseDefaultFiles();
app.UseStaticFiles();

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseCors("AllowAngular");

// 🔹 API endpoints
app.MapControllers();

app.MapFallbackToFile("index.html");

app.Run();
