// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcService;

var message = new HelloRequest
{ 
    Name = "Datsunbae"
};
var channel = GrpcChannel.ForAddress("http://localhost:5267");
var client = new Greeter.GreeterClient(channel);
var reponse = await client.SayHelloAsync(message);
Console.WriteLine(reponse.Message);
Console.ReadLine();
