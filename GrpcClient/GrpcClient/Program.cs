using Grpc.Net.Client;
using GrpcClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7011");//grpc service
var client = new Greeter.GreeterClient(channel);

//request
HelloReply result = await client.SayHelloAsync(new HelloRequest
{
    Name = "Alican"
});
Console.WriteLine(result.Message);