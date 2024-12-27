using AutoMapper;
using Demo.BLL.InterFaces;
using Demo.BLL.Repositories;
using Demo.PL.MappingProfiles;
using DemoDAL.Context;
using DemoDAL.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var Builder = WebApplication.CreateBuilder(args);
			#region Configure Services That Allow Dependancy Injection
			Builder.Services.AddControllersWithViews();
			Builder.Services.AddDbContext<MvcAppGo3DbContext>(options =>

			options.UseSqlServer(Builder.Configuration.GetConnectionString("DefaultConnection")));//Allow Dependancy injection


			Builder.Services.AddTransient<IDepartmentRepository, DepartmentRepository>();
			Builder.Services.AddAutoMapper(D => D.AddProfiles(new List<Profile>() { new EmployeeProfile(),
				new DepartmentProfile(),new UserProfile(),new RoleProfile()}));
			Builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();


			//services.AddScoped<UserManager<ApplicationUser>>();
			//services.AddScoped<SignInManager<ApplicationUser>>();
			Builder.Services.AddIdentity<ApplicationUser, IdentityRole>(Options =>
			{
				Options.Password.RequireNonAlphanumeric = true;
				Options.Password.RequireDigit = true;
				Options.Password.RequireLowercase = true;
				Options.Password.RequireUppercase = true;
			})
				.AddEntityFrameworkStores<MvcAppGo3DbContext>()
				.AddDefaultTokenProviders();

			Builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
				.AddCookie(Options =>
				{
					Options.LoginPath = "Account/Login";
					Options.AccessDeniedPath = "Home/Error";
				});
			#endregion
			var app = Builder.Build();
			#region Config. Http Request Pipelines
			if (app.Environment.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Account}/{action=Login}/{id?}");
			});
			#endregion
			app.Run();
		}


	}
}
