using Microsoft.EntityFrameworkCore;
using WebApplication_Mvc_1.Interfaces;
using WebApplication_Mvc_1.Persistence;
using WebApplication_Mvc_1.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(x => x.UseInMemoryDatabase("books-db"));
builder.Services.AddTransient<DataInitializer>();
builder.Services?.BuildServiceProvider().GetRequiredService<DataInitializer>().Init();
builder.Services.AddScoped<IScoringService, ScoreService>();
builder.Services.AddScoped<IBookService, BookService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
