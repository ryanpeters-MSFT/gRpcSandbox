# gRPC .NET/C# Code-First JWT Authentication Example

This example facilitates migration from WCF by leveraging a community-driven package called [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) in a code-first approach, as well as exposing a JWT endpoint and use of the `[Authorize]` attribute on a service method.

The **Service** application exposes a JWT HTTP/2 (HTTPS) endpoint (`/token/{name}`) to issue a token for the client. The **Client** application passes the JWT token into gRPC call as a Bearer token and passed in as a second argument to a method call as a `CallContext` argument containing the request header information.

The example also demonstates use of standard DI using the `IServiceCollection` and `IServiceProvider` to get an instance of the `ILogger<T>` for the Service application.

To run the application, run both the Client and Service applications and to view the output from the method invocation.