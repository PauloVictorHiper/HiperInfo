using Application.Api.HiperHub.Interfaces.Repositories;
using Application.Api.HiperHub.Models;
using Newtonsoft.Json;

namespace Application.Api.HiperHub.Repositories;

public class ClientRepository : IClientRepository
{
    public ClientRepository()
    {
        
    }

    public void GetClients()
    {
        var client = JsonConvert.DeserializeObject<Client>(json);
    }
}
