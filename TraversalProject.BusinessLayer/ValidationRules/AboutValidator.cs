using FluentValidation;
using System;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık boş bırakılamaz.")
                .MinimumLength(3).WithMessage("Başlık en az 3 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olabilir.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Açıklama en az 10 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("Açıklama en fazla 1000 karakter olabilir.");

            RuleFor(x => x.Title2)
                .NotEmpty().WithMessage("İkinci başlık boş bırakılamaz.")
                .MinimumLength(3).WithMessage("İkinci başlık en az 3 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("İkinci başlık en fazla 100 karakter olabilir.");

            RuleFor(x => x.Description2)
                .NotEmpty().WithMessage("İkinci açıklama boş bırakılamaz.")
                .MinimumLength(10).WithMessage("İkinci açıklama en az 10 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("İkinci açıklama en fazla 1000 karakter olabilir.");

            RuleFor(x => x.Image)
                .NotEmpty().WithMessage("Görsel URL'si boş bırakılamaz.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Geçerli bir görsel URL'si giriniz.");
        }
    }
}
