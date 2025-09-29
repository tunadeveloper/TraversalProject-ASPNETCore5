using FluentValidation;
using System;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.NameSurname)
                .NotEmpty().WithMessage("İsim ve soyisim boş bırakılamaz.")
                .MinimumLength(3).WithMessage("İsim ve soyisim en az 3 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("İsim ve soyisim en fazla 100 karakter olabilir.");

            RuleFor(x => x.Comment)
                .NotEmpty().WithMessage("Yorum boş bırakılamaz.")
                .MinimumLength(10).WithMessage("Yorum en az 10 karakter olmalıdır.")
                .MaximumLength(500).WithMessage("Yorum en fazla 500 karakter olabilir.");

            RuleFor(x => x.ImageUrl)
                .NotEmpty().WithMessage("Görsel URL'si boş bırakılamaz.")
                .Must(url => Uri.IsWellFormedUriString(url, UriKind.Absolute))
                .WithMessage("Geçerli bir görsel URL'si giriniz.");
        }
    }
}
