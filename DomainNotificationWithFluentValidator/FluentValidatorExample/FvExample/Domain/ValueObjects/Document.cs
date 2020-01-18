using FluentValidator;
using FvExample.Domain.Validations;
using System.Collections.Generic;

namespace FvExample.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }

        public bool IsValid()
        {
            return new DocumentValidationContract(this).Contract.Valid;
        }

        public IReadOnlyCollection<Notification> Notifications()
        {
            return new DocumentValidationContract(this).Contract.Notifications;
        }

        public override string ToString()
        {
            return Number;
        }
    }
}
