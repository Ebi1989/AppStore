using Asp06Store.Core.Domain.Models;
using Asp06Store.Core.Domain.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace Asp06Store.ShopUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();


            services.AddMvc()
            .AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddDbContext<StoreDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StoreCnn")));
            services.AddScoped<IProductRepository, EfProductRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}/Page{PageNumber}");
                endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/Page{PageNumber}");
                endpoints.MapControllerRoute("pagination", "/{controller=home}/{action=index}/{category}");
                endpoints.MapDefaultControllerRoute();
            });


        }
    }
}
