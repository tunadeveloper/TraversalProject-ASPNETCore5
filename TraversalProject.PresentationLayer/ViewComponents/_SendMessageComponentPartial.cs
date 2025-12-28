using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.PresentationLayer.ViewComponents
{
    public class _SendMessageComponentPartial:ViewComponent
    {
        

        public IViewComponentResult Invoke(ContactUs contactUs)
        {
            return View(contactUs);
        }
}
}
