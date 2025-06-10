var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSession();


// Agregás servicios de MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();


// Middleware
app.UseStaticFiles();
app.UseRouting();
app.UseSession(); // <- Esto es lo nuevo
app.UseAuthorization();

// registro de rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");

app.Run();
