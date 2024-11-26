using lms_api.Application.Books.Repositories.Implementations;
using lms_api.Application.Books.Repositories.Interfaces;
using lms_api.Application.Borrows.Repositories.Implementations;
using lms_api.Application.Borrows.Repositories.Interfaces;
using lms_api.Application.Reservations.Repositories.Implementations;
using lms_api.Application.Reservations.Repositories.Interfaces;
using lms_api.Application.Users.Repositories.Implementations;
using lms_api.Application.Users.Repositories.Interfaces;
using lms_api.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=LibraryDB;Username=postgres;Password=1111;")
    .EnableDetailedErrors());

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IBorrowRepository, BorrowRepository>();
builder.Services.AddScoped<IReservationRepository, ReservationRepository>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173", "https://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
