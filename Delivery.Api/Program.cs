

using Delivery.Core.Interfaces;
using Delivery.Infrastructure.Data;
using Delivery.Infrastructure.Mappings;
using Delivery.Infrastructure.Respositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program).Assembly, typeof(Automapper_Profile).Assembly);
builder.Services.AddControllers();


builder.Services.AddDbContext<DB_MafiaTechContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("MafiaTech")));


builder.Services.AddTransient<ITblClienteRepository, TblClienteRepository>();
builder.Services.AddTransient<ITblProductoRepository, TblProductoRepository>();        
builder.Services.AddTransient<ITblPedidoRepository, TblPedidoRepository>();
builder.Services.AddTransient<ITblDetallepedidoRepository, TblDetallepedidoRespository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcor e/swashbuckle
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
