namespace ElecShopApi;
public class ElectricalItemStorage{
    public ElectricalItemStorage(){}
    public List<ElectricalItem> items = new List<ElectricalItem>(){
        new ElectricalItem( 1,  "Beko Fridge Freezer", "Fridge Freezer", "A free standing fridge freezer", 300.00,"https://assets.products-live.ao.com/Images/5e5a59bf-124f-4cb5-be65-de061e6de323/RB34T652ESA_SI18496.jpg"),
        new ElectricalItem( 2,  "LG Smart TV", "TV", "65 inch LG TV with stunning realism and sharp images", 1600.00,"https://media.ao.com/en-GB/Productimages/Images/rvMedium/uqyv5wlealwr7wbqwujgs5-qe65q80ba_samsung_ql_m_p.png"),
        new ElectricalItem( 3,  "Sharp Standard Dishwasher", "Dishwasher", "A Dishwasher with height adjustable top basket.", 299.00,"https://media.ao.com/en-GB/Productimages/Images/rvMedium/oqkcgutxrfqbky16nw84na-dvn04x20s_si_m_p.jpg"),
        new ElectricalItem( 4,  "Bosch Standard Wifi Connected Dishwasher", "Dishwasher", " A wifi connected Dishwasher that connects to your smartphone.", 429.00, "https://media.ao.com/en-GB/Productimages/Images/rvMedium/oqkcgutxrfqbky16nw84na-dvn04x20s_si_m_p.jpg")
    };
}