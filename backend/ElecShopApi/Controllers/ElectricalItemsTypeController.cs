using Microsoft.AspNetCore.Mvc;

namespace ElecShopApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ElectricalItemTypeController : ControllerBase
{
    [HttpGet("GetAllElectricalItems/{type}")]
    public List<ElectricalItem> Get(string type)
    {
        return ElectricalItemStorage.items.Where(item => item.Type.ToLower() == type.ToLower()).ToList();
    }
}



