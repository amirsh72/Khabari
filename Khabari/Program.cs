using _0_Framework.Application;
using Khabari;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsManagement.Application;
using NewsManagement.Application.Contracts.NewsCategory;
using NewsManagement.Application.Contracts.OneNews;
using NewsManagement.Domain;
using NewsManagement.Infrastructure.EFCore;
using NewsManagement.Infrastructure.EFCore.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<IOneNewRepository, OneNewsRepository>();
builder.Services.AddTransient<INewsCategoryApplication, NewsCategoryApplication>();
builder.Services.AddTransient<INewsCategoryRepository, NewsCategoryRepository>();
builder.Services.AddTransient<IOneNewsApplication, OneNewsApplication>();
builder.Services.AddTransient<IOneNewRepository, OneNewsRepository>();

builder.Services.AddTransient<IFileUploader, FileUploader>();

builder.Services.AddDbContext<OneNewsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("khabari"));
});


var app = builder.Build();

IConfiguration configuration= app.Configuration;
IWebHostEnvironment environment = app.Environment;





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
