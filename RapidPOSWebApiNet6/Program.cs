using Microsoft.EntityFrameworkCore;
using RapidPOSWebApiNet6.Data;
using RapidPOSWebApiNet6.Data.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//add a custom dbcontext
builder.Services.AddDbContext<ApiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RapidPOSDBConnectionString")));

//configure custom services
builder.Services.AddTransient<CustomerService>();
builder.Services.AddTransient<PaymentService>();
builder.Services.AddTransient<SaleStoreService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
