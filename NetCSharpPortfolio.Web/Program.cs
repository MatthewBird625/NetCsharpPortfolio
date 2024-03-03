using MudBlazor.Services;
using NetCSharpPortfolio.Data.Services;
using NetCSharpPortfolio.Data.Services.Implementation;
using NetCSharpPortfolio.UiLogic.ViewModels;
using NetCSharpPortfolio.UiLogic.ViewModels.Implementation;
using NetCSharpPortfolio.Web.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services
    .AddTransient<IHomeViewModel, HomeViewModel>()
    .AddTransient<IPortfolioDataService, PortfolioDataService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
