using BlazorTestApp.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorTestApp.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Add a service and inject it in ExampleComponent
//Transient objects are always different; a new instance is provided to every controller and every service.
builder.Services.AddTransient<RandomService>();
//Singleton objects are the same for every object and every request.
//builder.Services.AddSingleton<RandomService>();
//Scoped objects are the same within a request, but different across different requests.
//builder.Services.AddScoped<RandomService>();

//Add another service, but it is injected in ExampleChildComponent
builder.Services.AddScoped<RandomServiceTwo>();

await builder.Build().RunAsync();
