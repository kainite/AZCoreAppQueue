using System;
using System.Collections.Generic;
using System.Text;

namespace StorageQueueSend
{
    class Video
    {
        public string Id { get; set; }
        public string name { get; set; }

        public Video()
        {
            Id = Guid.NewGuid().ToString();
            var random = new Random();
            var list = new List<string> { "How to create .Net Core App to send and receive messages to Queue on Storage Account",
                                          "How to create .Net Core App to interact with Cosmo DB on Storage Account",
                                          "How to deploy .Net core application into a Linux VM with Docker & Nginx",
                                          "How to Create a Azure Function App with Classes and use postman",
                                          "How to Build a Bot for Coinbase Pro",
                                          "How to install Docker and Nginx Web Server on Azure Linux VM",
                                          "How to use Selenium for Microsoft Dynamics CRM"
            };
            int index = random.Next(list.Count);
            name = list[index];
        }

        public override string ToString()
        {
            return $"Id : {Id}, Quantity : {name}";
        }
    }
}
