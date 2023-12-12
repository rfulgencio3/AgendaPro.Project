using AgendaPro.WebApp.Entities;

namespace AgendaPro.WebApp.Models;

public class MessageDataModel
{
    public string Message { get; set; }
    public string To { get; set; }
    public string Type { get; set; }
    public Template Template { get; set; }
}
