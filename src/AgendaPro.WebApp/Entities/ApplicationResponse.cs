namespace AgendaPro.WebApp.Entities;

public class ApplicationResponse
{
    public string MessagingProduct { get; set; }
    public List<Contact> Contacts { get; set; }
    public List<Message> Messages { get; set; }
}
