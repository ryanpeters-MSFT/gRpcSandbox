# gRPC .NET/C# Code-First Example

This example facilitates migration from WCF by leveraging a community-driven package called [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) in a code-first approach.

To facilitate migrations from WCF to gRPC, this code-first approach uses familiar WCF constructs and types, such as `[ServiceContract]`, `[OperationContract]`, `[DataContract]`, `[DataMember]`, etc.

The Common project contains shared resources, such as the request and reply class types as well as the [`IGreeterService`](./Common/IGreeterService.cs) interface that is used by both the client and the service applications.