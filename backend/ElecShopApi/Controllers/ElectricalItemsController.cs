using Microsoft.AspNetCore.Mvc;

namespace ElecShopApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ElectricalItemsController : ControllerBase
{
    ElectricalItemStorage elecItems = new ElectricalItemStorage();
    [HttpGet("GetAllElectricalItems")]
    public List<ElectricalItem> Get()
    {
        return elecItems.items;
    }
}
