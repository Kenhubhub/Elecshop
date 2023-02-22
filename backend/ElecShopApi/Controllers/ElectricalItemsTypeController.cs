using Microsoft.AspNetCore.Mvc;

namespace ElecShopApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ElectricalItemTypeController : ControllerBase
{
  ElectricalItemStorage elecItems = new ElectricalItemStorage();
    [HttpGet("GetAllElectricalItems/{type}")]
    public List<ElectricalItem> Get(string type)
    {
        return elecItems.items.Where(item => item.Type.ToLower() == type.ToLower()).ToList();
    }
}



