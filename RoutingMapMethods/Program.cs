var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/Home",async (context) =>
{

    await context.Response.WriteAsync("This is home page Map Get");

});

    endpoints.MapPost("/Home", async (context) =>
    {

        await context.Response.WriteAsync("This is home page map post");

    });
    endpoints.MapPut("/Home", async (context) =>
    {

        await context.Response.WriteAsync("This is home page  map put ");

    });

    endpoints.MapDelete("/Home", async (context) =>
    {

        await context.Response.WriteAsync("This is home page Delete");

    });


});
app.Run(async(HttpContext context) =>
    {
        await context.Response.WriteAsync("Page not found");
    });



//app.Map("/Home", () => "Hello World!");
//app.MapGet("/Home", () => "Hello World Get method!");
//app.MapPost("/Home", () => "Hello World POST method!");
//app.MapPut("/Home", () => "Hello World Put method!");
//app.MapDelete("/Home", () => "Hello World DELETE method!");


app.Run();
