using ProtoBuf.Grpc;
using System.ServiceModel;

namespace Common
{
    [ServiceContract]
    public interface IGreeterService
    {
        [OperationContract]
        Task<HelloReply> SayHello(HelloRequest request, CallContext context = default);
    }

}
