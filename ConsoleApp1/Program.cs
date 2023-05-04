using ConsoleApp1;
using ConsoleApp1.IOC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = Startup.CreateHostBuilder().Build();
var circle = host.Services.GetService<ICircle>();
var result = circle?.Calculate(56);
Console.WriteLine(result);





