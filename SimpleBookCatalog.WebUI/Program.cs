using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.BusinessLogic.Abstractions;
using SimpleBookCatalog.BusinessLogic.Services;
using SimpleBookCatalog.DataAccess.Context;
using SimpleBookCatalog.DataAccess.Repositories;
using SimpleBookCatalog.WebUI.Components;
using SimpleBookCatalog.WebUI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

builder.Services.AddApplicationServices();

builder.Services.AddDbContext<SimpleBookCatalogDbContext>(options =>
{
    options.UseSqlServer("server=(localdb)\\mssqllocaldb;database=SimpleBookCatalogDb;integrated security=true");
});

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));



//builder.Services.AddTransient<BookService>();
//builder.Services.AddSingleton<IBookRepository,BookRepository>();

//builder.Services.AddScoped<BookService>();

//builder.Services.AddScoped<IBookRepository>(sp=>
//new LoggingBookRepository(sp.GetRequiredService<BookRepository>()));

//builder.Services.AddScoped<BookRepository>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
