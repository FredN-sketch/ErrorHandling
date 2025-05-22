

var builder = WebApplication.CreateBuilder(new WebApplicationOptions {

    EnvironmentName = Environments.Production

});

builder.Services.AddControllersWithViews();
var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/throw");
    app.UseExceptionHandler("/error/exception");
    app.UseStatusCodePagesWithRedirects("/error/http/{0}");
}

//else
//{
//    app.UseExceptionHandler("/error/exception");
//}
app.MapControllers();
app.Run();
