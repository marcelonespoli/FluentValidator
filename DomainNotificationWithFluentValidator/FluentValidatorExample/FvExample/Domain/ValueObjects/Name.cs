using FluentValidator;

namespace FvExample.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            if (FirstName.Length <= 0)
                AddNotification("FirstName", "Name invalid");

            if (LastName.Length <= 0)
                AddNotification("LastName", "Lastname invalid");
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
