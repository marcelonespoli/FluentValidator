using FvExample.Domain.ValueObjects;
using System;

namespace FvExample
{
    class program
    {
        static void Main(string[] args)
        {
            var name = new Name("", "");

            foreach (var notification in name.Notifications)
            {
                Console.WriteLine(notification.Message);
                Console.WriteLine(name.Valid);
            }

            Console.ReadKey();
        }
    }
}
