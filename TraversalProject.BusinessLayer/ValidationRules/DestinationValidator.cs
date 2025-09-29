using FluentValidation;
using System;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class DestinationValidator : AbstractValidator<Destination>
    {
        public DestinationValidator()
        {
            RuleFor(x => x.City)
                .NotEmpty().WithMessage("Şehir adı boş bırakılamaz.")
                .MinimumLength(2).WithMessage("Şehir adı en az 2 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Şehir adı en fazla 100 karakter olabilir.");

            RuleFor(x => x.DayNight)
                .NotEmpty().WithMessage("Gün/Gece bilgisi boş bırakılamaz.")
                .MaximumLength(50).WithMessage("Gün/Gece bilgisi en fazla 50 karakter olabilir.");

            RuleFor(x => x.Price)
                .GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Görsel URL'si boş bırakılamaz.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Geçerli bir görsel URL'si giriniz.");

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Açıklama en az 10 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("Açıklama en fazla 1000 karakter olabilir.");

            RuleFor(x => x.Capacity)
                .GreaterThan(0).WithMessage("Kapasite 0'dan büyük olmalıdır.");
        }
    }
}
