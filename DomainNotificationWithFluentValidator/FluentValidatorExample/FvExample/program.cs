using FvExample.Domain.Entities;
using FvExample.Domain.ValueObjects;
using System;

namespace FvExample
{
    class program
    {
        static void Main(string[] args)
        {
            var name = new Name("", "");
            var email = new Email("@test.com");
            var document = new Document("1234567891");

            var studant = new Student(name, document, email);


            Console.WriteLine($"Student is valid: {studant.IsValid()}");

            foreach (var notification in studant.Notifications())
            {
                Console.WriteLine(notification.Message);                
            }

            Console.ReadKey();
        }
    }
}
