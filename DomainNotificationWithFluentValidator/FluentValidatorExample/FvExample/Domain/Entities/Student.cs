using FluentValidator;
using FvExample.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace FvExample.Domain.Entities
{
    public class Student
    {
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
        }

        public bool IsValid()
        {
            return Name.IsValid() && Email.IsValid() && Document.IsValid();
        }

        public List<Notification> Notifications()
        {
            return Name.Notifications()
                    .Concat(Email.Notifications())
                    .Concat(Document.Notifications())
                    .ToList();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
    }
}
