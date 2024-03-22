using Common;
using Grpc.Core;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Grpc.Client;
using System.Net;

var builder = Host.CreateApplicationBuilder();

var app = builder.Build();

var configuration = app.Services.GetService<IConfiguration>();
var url = configuration["RpcEndpoint"];

// Authenticate to get JWT token
var httpClient = new HttpClient
{
    DefaultRequestVersion = HttpVersion.Version30,
    DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
};

var request = new HttpRequestMessage(HttpMethod.Get, $"{url}/token/ryan")
{
    Version = new Version(2, 0)
};

var response = await httpClient.SendAsync(request);

var body = await response.Content.ReadAsStringAsync();

var channel = GrpcChannel.ForAddress(url);

var client = channel.CreateGrpcService<IGreeterService>();

var options = new CallOptions(new Metadata
{
    { "Authorization", $"Bearer {body}" }
});

var reply = await client.SayHello(new HelloRequest { Name = "Ryan James Peters", Age = 40 }, new ProtoBuf.Grpc.CallContext(options));

Console.WriteLine("Greeting: " + reply.Message);

foreach (var name in reply.Names)
{
    Console.WriteLine(name);
}