using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using TraversalProject.DTOLayer.DTOs.AnnouncementDTOs;
using TraversalProject.DTOLayer.DTOs.AppUserDTOs;
using TraversalProject.DTOLayer.DTOs.CİtyDTOs;
using TraversalProject.DTOLayer.DTOs.DestinationDTOs;
using TraversalProject.DTOLayer.DTOs.MailDTOs;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.PresentationLayer.Models;

namespace TraversalProject.PresentationLayer.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDTO, Announcement>();
            CreateMap<Announcement, AnnouncementAddDTO>();

            CreateMap<CityAddDTO, City>();
            CreateMap<City, CityAddDTO>();

            CreateMap<AppUserRegisterDTO, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTO>();

            CreateMap<AppUserLoginDTO, AppUser>();
            CreateMap<AppUser, AppUserLoginDTO>();

            CreateMap<DestinationAddDTO, Destination>();
            CreateMap<Destination, DestinationAddDTO>();

            CreateMap<MailRequestDTO, EmailRequest>();
            CreateMap<EmailRequest, MailRequestDTO>();

            CreateMap<Announcement, AnnouncementListDTO>();
            CreateMap<AnnouncementListDTO, Announcement>();

            CreateMap<AnnouncementUpdateDTO, Announcement>();
            CreateMap<Announcement, AnnouncementUpdateDTO>();
        }
    }
}
