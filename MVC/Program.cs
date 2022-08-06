using Business.Abstract;
using Business.Concrete;
using DataAccess.Context;
using DataAccess.GenericRepository;
using DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<BlogContext>();

var connectionString = builder.Configuration.GetConnectionString("MysqlConnection");
builder.Services.AddDbContext<BlogContext>(options =>
{
    options.UseMySql("Server=3.137.76.131;Database=BlogDb;Uid=kubra;Pwd=Kk123456.;", new MySqlServerVersion(new Version("8.0.30")));
});

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IBlogService, BlogService>();
builder.Services.AddTransient<ICommentService, CommentService>();
builder.Services.AddTransient<IExperienceService, ExperienceService>();
builder.Services.AddTransient<ITagService, TagService>();
builder.Services.AddTransient<ISkillService, SkillService>();
builder.Services.AddTransient<ICategoryService, CategoryService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
