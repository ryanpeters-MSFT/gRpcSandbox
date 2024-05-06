using Common;
using ProtoBuf.Grpc;

namespace Service.Services
{
    public class GreeterService : IGreeterService
    {
        public Task<HelloReply> SayHello(HelloRequest request, CallContext context = default)
        {
            var names = request.Name.Split(" ");
            var id = new Random().Next(1, 10); // create a random ID

            var reply = new HelloReply
            {
                Id = id,
                Message = $"Hello {request.Name}. You're {request.Age} years old!",
                Names = names
            };

            return Task.FromResult(reply);
        }
    }
}
