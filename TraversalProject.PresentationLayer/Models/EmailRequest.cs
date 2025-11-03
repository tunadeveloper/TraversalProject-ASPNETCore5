namespace TraversalProject.PresentationLayer.Models
{
    public class EmailRequest
    {
        public string NameSurname { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverEmail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
