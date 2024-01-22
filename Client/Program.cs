using Grpc.Net.Client;
using Service;

var channel = GrpcChannel.ForAddress("http://localhost:5043");

var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = "Mr. Ryan", Age = 40 });

Console.WriteLine("Greeting: " + reply.Message);