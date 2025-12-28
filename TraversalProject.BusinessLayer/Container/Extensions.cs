using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Abstract.UnitOfWork;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.BusinessLayer.Concrete.UnitOfWork;
using TraversalProject.BusinessLayer.ValidationRules;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract.UnitOfWork;
using TraversalProject.DataAccessLayer.EntityFramework;
using TraversalProject.DataAccessLayer.EntityFramework.UnitOfWork;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.DataAccessLayer.UnitOfWork;
using TraversalProject.DTOLayer.DTOs.AnnouncementDTOs;

namespace TraversalProject.BusinessLayer.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            services.AddScoped<ISubAboutService, SubAboutManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonalService, TestimonialManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IReservationDal, EFReservationDal>();
            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<INewsletterDal, EfNewsletterDal>();
            services.AddScoped<INewsletterService, NewsletterManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

        }

        public static void CustomerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTO>, AnnouncementValidator>();
        }
    }
}
