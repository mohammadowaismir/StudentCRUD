using Microsoft.EntityFrameworkCore;
using StudentCRUD.Web.StudentDBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContextPool<StudentDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString(nameof(StudentDbContext))));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorPages();

app.Run();
