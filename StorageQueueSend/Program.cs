using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Queue;
using System;

namespace StorageQueueSend
{
    class Program
    {
        private static string queue_connection_string = "DefaultEndpointsProtocol=https;AccountName=hugosilvastorage;AccountKey=v6k2ElufsjO1fz3cKGq/X2gcYCghmqhlFm5XgekkO7md/ZHjwwHfoApwhWqPX2FaXCH/b1XeWASZDZS1eYfcEQ==;EndpointSuffix=core.windows.net";
        private static string queue_name = "appqueue";
        static void Main(string[] args)
        {
            
            CloudStorageAccount queue_acc = CloudStorageAccount.Parse(queue_connection_string);
            
            CloudQueueClient queue_client = queue_acc.CreateCloudQueueClient();
            
            CloudQueue _queue = queue_client.GetQueueReference(queue_name);

            for (int i = 1; i < 5; i++)
            {
                Video obj = new Video();
                CloudQueueMessage _message = new CloudQueueMessage(obj.ToString());
                _queue.AddMessage(_message);
            }

            Console.WriteLine("All messages sent");
            Console.ReadLine();


        }
    }
}
