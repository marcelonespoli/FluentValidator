using FluentValidator;
using FvExample.Domain.Validations;
using System.Collections.Generic;

namespace FvExample.Domain.ValueObjects
{
    public class Email 
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

        public bool IsValid()
        {
            return new EmailValidationContract(this).Contract.Valid;
        }

        public IReadOnlyCollection<Notification> Notifications()
        {
            return new EmailValidationContract(this).Contract.Notifications;
        }

        public override string ToString()
        {
            return Address;
        }
    }
}
