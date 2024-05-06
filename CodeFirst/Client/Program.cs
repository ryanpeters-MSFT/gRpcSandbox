using Common;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Grpc.Client;

Console.WriteLine("Waiting 2 seconds for service to become available...\n");
Thread.Sleep(2000);

var builder = Host.CreateApplicationBuilder();

var app = builder.Build();

var configuration = app.Services.GetRequiredService<IConfiguration>();
var url = configuration["RpcEndpoint"];

var channel = GrpcChannel.ForAddress(url);

var client = channel.CreateGrpcService<IGreeterService>();

var reply = await client.SayHello(new HelloRequest { Name = "Ryan James Peters", Age = 40 });

Console.WriteLine("Greeting: " + reply.Message);

foreach (var name in reply.Names)
{
    Console.WriteLine(name);
}