using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL.Server;
using GraphQL.Types;
using GraphQlProject.Data;
using GraphQlProject.Data.CoffeeShop;
using GraphQlProject.Interfaces;
using GraphQlProject.Interfaces.CoffeeShop;
using GraphQlProject.Mutation;
using GraphQlProject.Query;
using GraphQlProject.Query.CoffeeShop;
using GraphQlProject.Schema;
using GraphQlProject.Schema.CoffeeShop;
using GraphQlProject.Services;
using GraphQlProject.Services.CoffeeShop;
using GraphQlProject.Type;
using GraphQlProject.Type.CoffeeShop;
using Microsoft.EntityFrameworkCore;

namespace GraphQlProject
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

            #region GraphQLExample

            //services.AddTransient<IProductService, DummyProductService>();
            //services.AddTransient<IProductService, ProductService>();
            //services.AddTransient<ProductType>();
            //services.AddTransient<ProductQuery>();
            //services.AddTransient<ProductMutation>();
            //services.AddTransient<ISchema, ProductSchema>();



            //services.AddDbContext<GraphQlDbContext>(options =>
            //    options.UseSqlServer(
            //        Configuration.GetConnectionString("GraphQLConnectionString")));

            #endregion

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            #region CoffeeShopExample

            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<ISubMenuService, SubMenuService>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<MenuType>();
            services.AddTransient<SubMenuType>();
            services.AddTransient<ReservationType>();
            services.AddTransient<MenuQuery>();
            services.AddTransient<SubMenuQuery>();
            services.AddTransient<ReservationQuery>();
            services.AddTransient<RootQuery>();
            services.AddTransient<ISchema, RootSchema>();

            services.AddDbContext<CoffeeShopDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("CoffeeShopConnectionString")));

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, /*GraphQlDbContext graphQlDbContext,*/ CoffeeShopDbContext coffeeShopDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //graphQlDbContext.Database.EnsureCreated();
            coffeeShopDbContext.Database.EnsureCreated();
            app.UseGraphiQl("/graphql");
            app.UseGraphQL<ISchema>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
