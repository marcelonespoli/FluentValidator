using FluentValidator.Validation;
using FvExample.Domain.ValueObjects;

namespace FvExample.Domain.Validations
{
    public class DocumentValidationContract : IContract
    {
        public ValidationContract Contract { get; }

        public DocumentValidationContract(Document document)
        {
            Contract = new ValidationContract();
            Contract
                .Requires()
                .HasLen(document.Number, 11,"Number", "Identity Number invalid");
        }
    }
}
