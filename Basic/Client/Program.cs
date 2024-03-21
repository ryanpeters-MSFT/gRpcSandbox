using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Service;

var build = Host.CreateApplicationBuilder();

var app = build.Build();

var url = app.Services.GetService<IConfiguration>();

var channel = GrpcChannel.ForAddress(url["RpcEndpoint"]);

var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Mr. Ryan", Age = 40 });

Console.WriteLine("Greeting: " + reply.Message);