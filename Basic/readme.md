# gRPC .NET/C# Basic Example

***This example uses `proto` files for type definition***

This is a basic example of a client and server application running gRPC. Data types are defined in the `greet.proto` file, which defines the service/type definition, the message structure, and is used to generate the supporting client code for the method calls. This proto file serves as a contract between the client and the server.

The project makes use of a shared `Protos` project file containing the [`greet.proto`](./Protos/greet.proto) file that is used as a contact between the client and server. The `link` attribute in the `<Protobuf>` node in the project file creates a shared file-level "link" between the two applications.