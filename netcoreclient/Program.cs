﻿using System;
using Grpc.Core;
using Sample;

namespace netcoreclient
{
    class Program
    {
        static void Main(string[] args)
        {
            var channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);

            var client = new ReverseService.ReverseServiceClient(channel);

            var reply = client.ReverseString(new ReverseRequest
            {
                Data = "Hello, World"
            });

            Console.WriteLine("Got: " + reply.Reversed);

            channel.ShutdownAsync().Wait();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
