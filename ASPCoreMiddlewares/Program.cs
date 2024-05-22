namespace ASPCoreMiddlewares
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();


            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Home }/{action=About}/{id?}"
               );

            //app.UseRouting();

            //app.MapGet("/", () => "Hello World!");

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("1st Block \n");
            //    await next(context);
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Welcome to ASP.NEt Core");
            //});



            //app.MapControllers();

            //app.MapGet("/Home", () => "Get");
            //app.MapPost("/Home", () => "Post");

            //app.UseEndpoints(endpoints => {
            //    endpoints.MapGet("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Get");

            //    });
            //    endpoints.MapPost("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Post");
            //    });
            //    endpoints.MapPut("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync
            //        ("Put");
            //    });
            //    endpoints.MapDelete("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync
            //        ("Delete");
            //    });
            //}); 

            // app.Run(async(HttpContext context) =>
            //{
            //    await context.Response.WriteAsync ("Page Not Found");
            //});

            app.Run();
        }
    }
}
