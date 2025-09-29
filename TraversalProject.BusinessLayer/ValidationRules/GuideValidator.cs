using FluentValidation;
using System;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class GuideValidator : AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.NameSurname)
                .NotEmpty().WithMessage("İsim ve soyisim boş bırakılamaz.")
                .MinimumLength(3).WithMessage("İsim ve soyisim en az 3 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("İsim ve soyisim en fazla 100 karakter olabilir.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Açıklama en az 10 karakter olmalıdır.")
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Görsel URL'si boş bırakılamaz.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Geçerli bir görsel URL'si giriniz.");

            RuleFor(x => x.XUrl)
                .Must(url => string.IsNullOrEmpty(url) || Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("X URL geçerli bir link olmalıdır.");

            RuleFor(x => x.InstagramUrl)
                .Must(url => string.IsNullOrEmpty(url) || Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Instagram URL geçerli bir link olmalıdır.");
        }
    }
}
