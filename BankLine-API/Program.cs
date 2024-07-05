using BankLine_API.Data;
using BankLine_API.Repository.Correntistas;
using Microsoft.EntityFrameworkCore;
using BankLine_API.Repository.Correntistas;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICorrentistaService, CorrentistaService>();

// Connection String
builder.Services.AddDbContext<BankLineDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankLineCS")));

builder.Services.AddScoped<ICorrentistaRepository, CorrentistaRepository>();
builder.Services.AddScoped<ICorrentistaService, CorrentistaService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
