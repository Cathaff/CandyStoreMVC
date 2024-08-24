using CandyStore.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<CandyStoreDbContext>(
//    dbContextOptions => dbContextOptions.UseSqlite(
//        builder.Configuration["ConnectionStrings:CityInfoDBConnectionString"]));

builder.Services.AddDbContext<CandyStoreDbContext>(
    dbContextOptions => dbContextOptions.UseSqlite("Data Source = CandyStore.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    app.MapControllers();
});

app.MapControllers();

app.Run();
