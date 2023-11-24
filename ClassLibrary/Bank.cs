using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bank
    {
        private Queue<Client> clientQueue = new Queue<Client>();

        // Добавление клиента в очередь
        public void AddClient(Client client)
        {
            clientQueue.Enqueue(client);
            Console.WriteLine($"Клиент {client.Name} добавлен в очередь.");
            ShowQueue();
        }

        // Обслуживание клиента
        public void ServiceClient()
        {
            if (clientQueue.Count > 0)
            {
                Client nextClient = clientQueue.Dequeue();
                Console.WriteLine($"Обслужен клиент {nextClient.Name}.");
                ShowQueue();
            }
            else
            {
                Console.WriteLine("Очередь пуста.");
            }
        }

        // Показать текущую очередь
        private void ShowQueue()
        {
            Console.WriteLine("Текущая очередь:");
            foreach (var client in clientQueue)
            {
                Console.WriteLine($"Клиент {client.Name} ({client.ServiceType})");
            }
            Console.WriteLine();
        }
    }
}
