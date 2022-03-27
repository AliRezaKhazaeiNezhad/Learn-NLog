using KhN.LogingLibrary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient(typeof(Microsoft.Extensions.Logging.ILogger<>), typeof(Microsoft.Extensions.Logging.Logger<>));
//builder.Services.AddTransient(typeof(KhN.LogingLibrary.ILogger<>), typeof(NLogAdapter<>));
//builder.Services.AddTransient(typeof(KhN.LogingLibrary.ILogger<>), typeof(Log4NetAdapter<>));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();
app.MapControllerRoute(
       name: "default",
       pattern: "api/{controller=Home}/{action=Index}/{id?}");

app.MapControllers();

app.Run();
