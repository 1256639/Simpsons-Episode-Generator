using Microsoft.EntityFrameworkCore;
using SimpsonsEpisodeGenerator.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<SimpsonsEpisodeGeneratorContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("SimpsonsEpisodeGenerator")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Episodes}/{action=Index}/{id?}"
);

app.MapRazorPages();

app.Run();
