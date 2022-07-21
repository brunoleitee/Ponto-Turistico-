using Microsoft.EntityFrameworkCore;
using McvCrud.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<McvCrudContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("McvCrudContext") ?? throw new InvalidOperationException("Connection string 'McvCrudContext' not found.")));



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
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
