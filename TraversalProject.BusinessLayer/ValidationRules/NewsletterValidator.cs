using FluentValidation;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class NewsletterValidator : AbstractValidator<Newsletter>
    {
        public NewsletterValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email alanı boş bırakılamaz.")
                .EmailAddress().WithMessage("Geçerli bir email adresi giriniz.");
        }
    }
}
