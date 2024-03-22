using Common;
using Microsoft.AspNetCore.Authorization;
using ProtoBuf.Grpc;

namespace Service.Services
{
    public class GreeterService : IGreeterService
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public Task<HelloReply> SayHello(HelloRequest request, CallContext context = default)
        {
            var names = request.Name.Split(" ");

            var reply = new HelloReply
            {
                Message = $"Hello {request.Name}. You're {request.Age} years old!",
                Names = names
            };

            return Task.FromResult(reply);
        }
    }
}
