using System;
using System.Net.Http;
using System.Threading.Tasks;
using Grpc.Net.Client;

namespace GrpcGreeterClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using GrpcChannel grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Greeter.GreeterClient(grpcChannel);

            HelloRequest helloRequest = new HelloRequest
            {
                Name = "GreeterClient"

            };
            HelloReply helloReply = await client.SayHelloAsync(helloRequest);

            Console.WriteLine("Greeting: " + helloReply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
