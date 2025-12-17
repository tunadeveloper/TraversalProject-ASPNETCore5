using FluentValidation;
using TraversalProject.DTOLayer.DTOs.AnnouncementDTOs;

namespace TraversalProject.BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Başlık boş bırakılamaz.")
                .MinimumLength(5).WithMessage("Başlık en az 5 karakter olmalıdır.")
                .MaximumLength(100).WithMessage("Başlık en fazla 100 karakter olabilir.");
            RuleFor(x => x.Content)
                .NotEmpty().WithMessage("İçerik boş bırakılamaz.")
                .MinimumLength(20).WithMessage("İçerik en az 20 karakter olmalıdır.")
                .MaximumLength(1000).WithMessage("İçerik en fazla 1000 karakter olabilir.");
        }
    }
}
