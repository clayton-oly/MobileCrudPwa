using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MobileCrudPwa.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configurar a URL base da API

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7128") }); //http da sua api

await builder.Build().RunAsync();
