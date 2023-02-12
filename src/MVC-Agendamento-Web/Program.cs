using Microsoft.EntityFrameworkCore;
using MVC_Agendamento_Application_Service.SQLServerServices;
using MVC_Agendamento_Domain.Contract.Repositories;
using MVC_Agendamento_Domain.Contracts.Services;
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
//builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
//builder.Services.AddScoped<IPatientRepository, PatientRepository>();
//builder.Services.AddScoped<IPersonRepository, PersonRepository>();
//builder.Services.AddScoped<IConditionRepository, ConditionRepository>();
//builder.Services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();
//builder.Services.AddScoped<IUserRepository, UserRepository>();



// # Services
builder.Services.AddScoped<IScheduleService, ScheduleService>();
//builder.Services.AddScoped<IServiceService, ServiceService>();
//builder.Services.AddScoped<IConditionService, ConditionService>();
//builder.Services.AddScoped<IDoctorService, DoctorService>();
//builder.Services.AddScoped<IPatientService, PatientService>();
//builder.Services.AddScoped<IPersonService, PersonService>();
//builder.Services.AddScoped<ISpecialtyService, SpecialtyService>();
//builder.Services.AddScoped<IUserService, UserService>();


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
