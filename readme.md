# gRPC .NET/C# Sample Applications

These sample applications demonstrate basic client/server requests using [gRPC](https://grpc.io/). 

To run a particular application, run both the Client and Service applications and to view the output from the method invocation. *If you are running in Visual Studio, configure your startup projects to run both client and server in debug or non-debug mode.*

## [Basic](./Basic/)

This example is a basic example of a client/server application, utilizing a shared `Protos` project containing the proto files used by both applications. 

## [Code-First](./CodeFirst/)

This example utilizes the community project [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) and WCF-friendly conventions to support a code-first implementation of gRPC.

## [Authentication](./Authentication/)

This example builds on top of [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) to support steps to invoke an endpoint to create a JWT token and pass the token in as a Bearer token to a RPC method.

## Links

- [gRPC .NET examples](https://github.com/grpc/grpc-dotnet/tree/master/examples)