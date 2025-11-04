using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.EntityFramework;

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
        }
    }
}
