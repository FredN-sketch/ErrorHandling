


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/throw");
    app.UseStatusCodePagesWithRedirects("/error/http/{0}");
}

else
{
    app.UseExceptionHandler("error/exception");
}
    app.MapControllers();
app.Run();
