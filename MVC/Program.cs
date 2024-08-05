using Business.DependencyResolvers.MicrosoftDI;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.ConfigureServices(configuration: builder.Configuration);

var app = builder.Build();

// Get the environment
var env = app.Environment;

// Configure the HTTP request pipeline.
if (!env.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // wwwroot klasörü için

// Diğer klasörleri de eklemek için
app.UseStaticFiles(new StaticFileOptions
{
	FileProvider = new PhysicalFileProvider(
		Path.Combine(env.ContentRootPath, "listany-package")),
	RequestPath = "/listany-package"
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
