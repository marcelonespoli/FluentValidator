using FluentValidator;

namespace FvExample.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            if (address.Length <= 5)
                AddNotification("Email", "E-mail invalid");
        }

        public string Address { get; private set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
