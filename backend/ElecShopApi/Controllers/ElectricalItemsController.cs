using Microsoft.AspNetCore.Mvc;

namespace ElecShopApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ElectricalItemsController : ControllerBase
{
    
    [HttpGet("GetAllElectricalItems")]
    public List<ElectricalItem> Get()
    {
        return ElectricalItemStorage.items;
    }
}
