using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.Services.AddressServiceFolder;
using HouseOwnerWebApi.Services.AgencyServiceFolder;
using HouseOwnerWebApi.Services.AnnouncmentServiceFolder;
using HouseOwnerWebApi.Services.HouseOwnerServiceFolder;
using HouseOwnerWebApi.Services.ImagesServiceFolder;
using HouseOwnerWebApi.Services.PriceServiceFolder;
using HouseOwnerWebApi.Services.SocialLinkServiceFolder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IHouseOwnerService, HouseOwnerService>();
builder.Services.AddScoped<IAnnouncmentService, AnnouncmentService>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IPriceService, PriceService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<ISocialLinkService, SocialLinkService>();
builder.Services.AddScoped<IAgencyService, AgencyService>();

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
