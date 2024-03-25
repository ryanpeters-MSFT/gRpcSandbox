using Grpc.Core;

namespace Service.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var names = request.Name.Split(" ");

            var reply = new HelloReply
            {
                Message = $"Hello {request.Name}. You're {request.Age} years old!"
            };

            reply.Names.AddRange(names);

            return Task.FromResult(reply);
        }
    }
}
