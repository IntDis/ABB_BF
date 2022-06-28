using ABB_BF.BLL.Config;
using ABB_BF.Config;
using ABB_BF.DAL;
using ABB_BF.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(ApiMapper), typeof(BllMapper));
builder.Services.RegisterRepositories();
builder.Services.RegisterServices();

// Config DbContext
const string _connectionStringVar = "CON_STRING1";
string connString = builder.Configuration.GetValue<string>(_connectionStringVar);

builder.Services.AddDbContext<Context>(op =>
            op.UseSqlServer(connString));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
