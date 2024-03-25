using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service;

var build = Host.CreateApplicationBuilder();

var app = build.Build();

var configuration = app.Services.GetService<IConfiguration>();
var url = configuration["RpcEndpoint"];

var channel = GrpcChannel.ForAddress(url);

var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Ryan James Peters", Age = 40 });

Console.WriteLine("Greeting: " + reply.Message);

foreach (var name in reply.Names)
{
    Console.WriteLine(name);
}