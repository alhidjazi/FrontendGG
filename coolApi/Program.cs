using coolApi.Data;
using coolApi.Interfaces;
using coolApi.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//controllers çalıştırabilmek için bu kod lazim
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DBCotext
builder.Services.AddDbContext<ApplicationDBContext>(option =>{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IStockRepository, StockRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); 

//controllers çalıştırabilmek için bu kod lazimdir
app.MapControllers();

app.Run();
// webApi oluşturmak için 'dotnet new webapi -o api' komutla 
// swagger çalıştırabilmek için bu komutla 'dotnet watch run'