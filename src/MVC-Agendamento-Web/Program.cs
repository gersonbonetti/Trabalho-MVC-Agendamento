using Microsoft.EntityFrameworkCore;
using MVC_Agendamento_Application_Service.SQLServerServices;
using MVC_Agendamento_Domain.IRepositories;
using MVC_Agendamento_Domain.IServices;
using MVC_Agendamento_Infra_Data.Context;
using MVC_Agendamento_Infra_Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context SQL Server
builder.Services.AddDbContext<SQLServerContext>
	(options => options.UseSqlServer("Server=LAPTOP-J7OCOHCR\\SQLEXPRESS;Database=Agendamento;User Id=sa;Password=admin;TrustServerCertificate=True;"));

// ### Dependency Injection
// # Repositories
builder.Services.AddScoped<IScheduleRepository, ScheduleRepository>();

// # Services
builder.Services.AddScoped<IScheduleService, ScheduleService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
