using PizzaKing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPizzaRepository, PizzaRepository>();
builder.Services.AddScoped<IFeedbackRepository, FeedbackRepository>();
// builder.Services.AddTransient()
// builder.Services.AddScoped()
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlite(builder.Configuration["ConnectionStrings:DefaultConnection"])
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// app.MapControllerRoute(
//     name: "Blog",
//     pattern: "blog/{year}/{month}/{day}",
//     defaults: new { controller = "Home", action = "GetPost"},
//     constraints: new { year=@"\d{4}", month=@"\d{1,2}", day=@"\d{1,2}"}
// );

app.MapGet("custom/{parameter}", (string parameter)=>{
    return $"you passed {parameter}";
});
// app.MapPost
// app.MapPut
// app.MapDelete

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
