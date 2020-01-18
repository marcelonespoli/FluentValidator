using FluentValidator.Validation;
using FvExample.Domain.ValueObjects;

namespace FvExample.Domain.Validations
{
    public class NameValidationContract : IContract
    {
        public ValidationContract Contract { get; }

        public NameValidationContract(Name name)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .HasMinLen(name.FirstName, 3, "FirstName", "The first name should have at least 3 characters")
                .HasMinLen(name.LastName, 3, "LastName", "The last name should have at least 3 characters")
                .HasMaxLen(name.FirstName, 60, "FirstName", "The first name should have maximums of 60 characters")
                .HasMaxLen(name.LastName, 60, "LastName", "The last name should have maximums of 60 characters");
        }
    }
}
