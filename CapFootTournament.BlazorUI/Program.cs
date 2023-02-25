global using CapFootTournament.BlazorUI.Services;
global using CapFootTournament.BlazorUI.Shared;
using CapFootTournament.BlazorUI;
using CapFootTournament.BlazorUI.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICapgeminiContract, CapgeminiService>();
builder.Services.AddScoped<ITournamentContract, TournamentService>();
await builder.Build().RunAsync();
