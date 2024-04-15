# gRPC .NET/C# Sample Applications

These sample applications demonstrate basic client/server requests using [gRPC](https://grpc.io/). 

## Comparison to WCF

- **gRPC** and **WCF** are both **RPC (remote procedure call)** frameworks, aiming to allow developers to code as if the client and server are on the same platform.
- While their implementation and approach differ, the experience of developing and consuming services with **gRPC** should be intuitive for **WCF** developers.
- Both require declaring and implementing an interface, although the process for declaring the interface varies.
- **gRPC** supports various types of RPC calls, which map well to the bindings available to **WCF** services.

## General Benefits of gRPC

### Performance
- **gRPC** uses **HTTP/2**, which offers several advantages over **HTTP/1.1**:
    - It's a smaller, faster binary protocol.
    - Computers parse it more efficiently.
    - It supports multiplexing requests over a single connection, eliminating head-of-line blocking (the blocking caused by the packet held up in a queue).
- **Protobuf**, an efficient binary format, serializes messages in **gRPC**:
    - Fast to serialize and deserialize.
    - Consumes less bandwidth than text-based formats.
    - Ideal for mobile devices and bandwidth-restricted networks.

### Interoperability

- **gRPC** provides tools and libraries for major programming languages and platforms, including **.NET**, **Java**, **Python**, **Go**, **C++**, and more.
- Thanks to the **Protobuf** binary wire format and efficient code generation, developers can build cross-platform, performant applications.

### Usability and Productivity

- **gRPC** is a comprehensive RPC solution that works consistently across multiple languages and platforms.
- It offers excellent tooling, with much of the boilerplate code automatically generated.
- Like **WCF**, **gRPC** automatically generates messages and a strongly typed client, freeing up developer time for business logic.

### Streaming

- **gRPC** supports full bidirectional streaming, similar to **WCF's** full duplex services.
- It operates over regular internet connections, load balancers, and service meshes.

### Deadlines, Timeouts, and Cancellation
- Clients can specify a maximum time for an RPC to finish in **gRPC**.
- If the deadline is exceeded, the server can cancel the operation independently of the client.

## [Basic](./Basic/)

This example is a basic example of a client/server application, utilizing a shared `Protos` project containing the proto files used by both applications. 

## [Code-First](./CodeFirst/)

This example utilizes the community project [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) and WCF-friendly conventions to support a code-first implementation of gRPC.

## [Authentication](./Authentication/)

This example builds on top of [protobuf-net.Grpc](https://protobuf-net.github.io/protobuf-net.Grpc/) to support steps to invoke an endpoint to create a JWT token and pass the token in as a Bearer token to a RPC method.

## Links

- [gRPC .NET examples](https://github.com/grpc/grpc-dotnet/tree/master/examples)