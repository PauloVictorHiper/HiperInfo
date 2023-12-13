using Application.Api.HiperHub.Models;
using Newtonsoft.Json;

namespace Application.Api.HiperHub.Repositories;

public class ClientRepository
{
    public ClientRepository()
    {
        
    }

    public void GetClients()
    {
        var client = JsonConvert.DeserializeObject<Client>(json);
    }
}
