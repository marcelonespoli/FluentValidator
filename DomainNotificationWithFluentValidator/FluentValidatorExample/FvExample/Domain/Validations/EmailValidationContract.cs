using FluentValidator.Validation;
using FvExample.Domain.ValueObjects;

namespace FvExample.Domain.Validations
{
    public class EmailValidationContract : IContract
    {
        public ValidationContract Contract { get; }

        public EmailValidationContract(Email email)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .IsEmail(email.Address, "Email", "E-mail invalid");
        }
    }
}
