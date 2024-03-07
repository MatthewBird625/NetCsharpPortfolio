using CSharpPortfolioNet7.Data.Services.Implementation;
using CSharpPortfolioNet7.Data.Services;
using CSharpPortfolioNet7.UiLogic.ViewModels.Implementation;
using CSharpPortfolioNet7.UiLogic.ViewModels;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddMudServices();

builder.Services
    .AddTransient<IHomeViewModel, HomeViewModel>()
    .AddTransient<IPortfolioDataService, PortfolioDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
