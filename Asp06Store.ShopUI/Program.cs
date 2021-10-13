using Asp06Store.Infra.Data.Sql.Common;
using Asp06Store.ShopUI;
using Serilog;

CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog(LoggingConfiguration.ConfigureLogger);

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();
//var cnnString = builder.Configuration.GetConnectionString("StoreCnn");
//builder.Services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(cnnString));
//builder.Services.AddScoped<IProductRepository, EfProductRepository>();
//builder.Services.AddMemoryCache();
//builder.Services.AddSession();
//var app = builder.Build();

//app.UseDeveloperExceptionPage();
//app.UseStatusCodePages();
//app.UseStaticFiles();
//app.UseSession();
//app.UseRouting();

//app.UseSerilogRequestLogging((loggerConfiguration) => LoggingConfiguration.ConfigureLogger(, loggerConfiguration));

//app.UseEndpoints(endpoints =>
//        {
//            endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}/Page{PageNumber}");
//            endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/Page{PageNumber}");
//            endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}");
//            endpoints.MapDefaultControllerRoute();
//        }
//    );

//app.Run();
