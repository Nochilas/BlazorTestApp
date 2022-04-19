using BlazorTestApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorTestApp.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Add a service and inject it in ExampleComponent
builder.Services.AddTransient<RandomService>();
//builder.Services.AddSingleton<RandomService>();
//builder.Services.AddScoped<RandomService>();

//Add another service, but it is injected in ExampleChildComponent
builder.Services.AddScoped<RandomServiceTwo>();

//Add a service to the Counter page
builder.Services.AddScoped<myCounter>();

await builder.Build().RunAsync();
