using HouseOwnerWebApi.Data;
using HouseOwnerWebApi.Models;
using HouseOwnerWebApi.Models.RepositoryInterface;
using HouseOwnerWebApi.Models.ServiceInterface;
using HouseOwnerWebApi.Repositories;
using HouseOwnerWebApi.Services;
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
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<IInterierCompanyService, InterierCompanyService>();

builder.Services.AddScoped<IHouseOwnerInterface, HouseOwnerRepository>();
builder.Services.AddScoped<IAnnouncmentInterface, AnnouncmentRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IAgencyRepository, AgencyRepository>();
builder.Services.AddScoped<ICompanyInterface, CompanyRepository>();
builder.Services.AddScoped<IImageInterface, ImageRepository>();




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
