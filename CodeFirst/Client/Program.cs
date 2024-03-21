﻿using Common;
using Grpc.Net.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProtoBuf.Grpc.Client;

var builder = Host.CreateApplicationBuilder();

var app = builder.Build();

var url = app.Services.GetService<IConfiguration>();

var channel = GrpcChannel.ForAddress(url["RpcEndpoint"]);

var client = channel.CreateGrpcService<IGreeterService>();

var reply = await client.SayHello(new HelloRequest { Name = "Ryan James Peters", Age = 40 });

Console.WriteLine("Greeting: " + reply.Message);

foreach (var name in reply.Names)
{
    Console.WriteLine(name);
}