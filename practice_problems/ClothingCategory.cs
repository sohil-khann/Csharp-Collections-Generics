using System;
namespace OnlineMarketPlace
{
    public class ClothingCategory//class for clothing category
    {
        public string Type { get; set; }
        public string Size { get; set; }

        public ClothingCategory(string type, string size) //constructor
        {
            Type = type;
            Size = size;
        }
    }
    
}