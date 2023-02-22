
namespace ElecShopApi{

    public class ElectricalItem{
        public ElectricalItem(int id, string name, string type, string description, double price,string imageUrl){
            Id = id;
            Name = name;
            Type = type;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
        }
        public int Id {get; set;}
        public string Name {get; set;}
        public string Type {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}
        public string ImageUrl { get; set;}

    }

}