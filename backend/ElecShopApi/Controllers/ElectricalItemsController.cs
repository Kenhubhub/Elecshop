using Microsoft.AspNetCore.Mvc;

namespace ElecShopApi.Controllers;

[ApiController]
[Route("[controller]")]

public class ElectricalItemsController : ControllerBase
{
    List<ElectricalItem> elecItems = new List<ElectricalItem>(){
        new ElectricalItem( 1,  "Beko Fridge Freezer", "Fridge Freezer", "A free standing fridge freezer", 300.00),
        new ElectricalItem( 2,  "LG Smart TV", "TV", "65 inch LG TV with stunning realism and sharp images", 1600.00),
        new ElectricalItem( 3,  "Sharp Standard Dishwasher", "Dishwasher", "A Dishwasher with height adjustable top basket.", 299.00),
        new ElectricalItem( 4,  "Bosch Standard Wifi Connected Dishwasher", "Dishwasher", " A wifi connected Dishwasher that connects to your smartphone.", 429.00)
    };

    [HttpGet("GetAllElectricalItems")]
    public List<ElectricalItem> Get()
    {
        return elecItems;
    }
}