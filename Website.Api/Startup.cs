using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;
using System.IO;
using System.Threading.Tasks;
using Website.Data;

namespace Website.Api
{
	public class Startup
	{
		public Startup(IConfiguration configuration) => Configuration = configuration;

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddEntityFrameworkNpgsql();
			services.AddDbContext<WebsiteDbContext>(options =>
			{
				string connectionString = Configuration["Storage:ConnectionString"];
				string assemplyName = typeof(WebsiteDbContext).Assembly.GetName().Name;
				options.UseNpgsql(connectionString, npgsqlOptions => { npgsqlOptions.MigrationsAssembly(assemplyName); });
			});
			services.AddControllers();
			AddSwaggerService(services);
		}
		public void Configure(IApplicationBuilder app)
		{
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
			UseSwagger(app);
		}

		private void AddSwaggerService(IServiceCollection services)
		{
			services.AddSwaggerGen(opt =>
			{
				opt.SwaggerDoc("v1", new OpenApiInfo { Title = "Документация API сайта кафедры ИУ-2 КФ МГТУ", Version = "v1" });
                opt.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Website.Data.xml"));
			});
		}
		private static void UseSwagger(IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(options =>
			{
				options.RoutePrefix = "swagger";
				options.SwaggerEndpoint("/swagger/v1/swagger.json", "default");
			});

			// Добавляем роут которые редиректнет пользователя в свагер при пустом роуте.
			app.Map(string.Empty, appBuilder =>
			{
				appBuilder.Run(async context => await Task.Run(() =>
				{
					var options = app.ApplicationServices.GetService<IOptions<SwaggerUIOptions>>().Value;
					context.Response.Redirect(options.RoutePrefix);
				}));
			});
		}
	}
}
