using FluentValidator;
using FvExample.Domain.Validations;
using System.Collections.Generic;

namespace FvExample.Domain.ValueObjects
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public bool IsValid()
        {
            return new NameValidationContract(this).Contract.Valid;
        }

        public IReadOnlyCollection<Notification> Notifications()
        {
            return new NameValidationContract(this).Contract.Notifications;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
