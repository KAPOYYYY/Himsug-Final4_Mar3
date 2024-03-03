global using Himsug_Final4.Server.Services;
using Microsoft.EntityFrameworkCore;
using Himsug_Final4.Shared;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<SQLDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<ProductDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<SupplierDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<PersonDBContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => 
    builder.WithOrigins("https://localhost:7262,http://localhost:5220")
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());
});

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
//addservices
builder.Services.AddScoped<IEmailservice, EmailService>();
builder.Services.AddTransient<IUser, UserManager>();
builder.Services.AddTransient<IProduct, ProductManager>();
builder.Services.AddScoped<ISuppliers, SupplierManager>();
builder.Services.AddScoped<IPerson, PersonManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();
app.UseCors("CorsPolicy");

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
