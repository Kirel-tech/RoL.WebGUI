using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RoL.Blazor;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient(new HttpClientHandler()) {BaseAddress = new Uri("http://servers.mix3.ru:6969/api/v1/")});
builder.Services.AddMudServices();

await builder.Build().RunAsync();