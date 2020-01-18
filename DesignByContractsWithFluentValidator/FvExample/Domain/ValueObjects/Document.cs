using FluentValidator;

namespace FvExample.Domain.ValueObjects
{
    public class Document : Notifiable
    {
        public Document(string number)
        {
            Number = number;

            if (Number.Length <= 11)
                AddNotification("Number", "Identity Number invalid");
        }

        public string Number { get; private set; }

        public override string ToString()
        {
            return Number;
        }
    }
}
