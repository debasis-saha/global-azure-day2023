using global_azure_day2023;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//var baseAddress = builder.HostEnvironment.BaseAddress;
var baseAddress = builder.Configuration["BaseAddress"] ?? builder.HostEnvironment.BaseAddress;

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(baseAddress) });

// configure httpclient
// call the following code please add packageMicrosoft.Extensions.Http 3.1.0
builder.Services.AddHttpClient("ServerAPI", client => client.BaseAddress = new Uri(baseAddress));
// register the httpclient
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("ServerAPI"));



await builder.Build().RunAsync();
