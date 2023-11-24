using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace dotNET_module_13_homework
{
    class Program
    {
        static void ex()
        {
            Bank bank = new Bank();
            bool isAdmin = false;

            while (true)
            {
                Console.WriteLine("1. Добавить клиента в очередь");
                Console.WriteLine("2. Обслужить клиента");

                if (isAdmin)
                {
                    Console.WriteLine("3. Войти как администратор");
                }

                Console.WriteLine("0. Выйти");

                Console.Write("Выберите действие: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите имя клиента: ");
                        string name = Console.ReadLine();

                        Console.Write("Введите тип обслуживания: ");
                        string serviceType = Console.ReadLine();

                        Random rnd = new Random();
                        int clientId = rnd.Next(1000, 9999);

                        Client newClient = new Client(clientId, name, serviceType);
                        bank.AddClient(newClient);
                        break;

                    case 2:
                        bank.ServiceClient();
                        break;

                    case 3:
                        if (!isAdmin)
                        {
                            Console.Write("Введите пароль: ");
                            string password = Console.ReadLine();

                            // Простая проверка пароля
                            if (password == "admin")
                            {
                                isAdmin = true;
                                Console.WriteLine("Вы вошли как администратор.");
                            }
                            else
                            {
                                Console.WriteLine("Неверный пароль.");
                            }
                        }
                        else
                        {
                            isAdmin = false;
                            Console.WriteLine("Выход из режима администратора.");
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            ex();
        }
    }
}
