
namespace ElecShopApi{

    public class ElectricalItem{
        public ElectricalItem(int id, string name, string type, string description, double price){
            Id = id;
            Name = name;
            Type = type;
            Description = description;
            Price = price;
        }
        public int Id {get; set;}
        public string Name {get; set;}
        public string Type {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}

    }

}