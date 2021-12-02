using System;
using System.Collections.Generic;

namespace app.Models
{


    /*
       https://craftbeeracademy.com/beer-characteristics/
    */
    public class Beer
    {

        public static List<string> Aromas = new List<string>() 
        {
            "Fruity",
            "Texture",
            "Floral",
            "Vegetal",
            "Spicy",
            "Heat-Induced",
            "Biological" 
        };
        public int    ID       { get; set; }
        public string Brewer   { get; set; }
        public string Name     { get; set; }
	    public string Color    { get; set; }
	    public string Clarity  { get; set; }
        public string Type     { get; set; }
	    public double ABV      { get; set; }
	    public double ABW      { get; set; }
        public double IBU      {get; set;}
        public int    Calories { get; set; }
	    public string Aroma    { get; set; }
    }
}
