using System;
using System.Collections.Generic;

namespace app.Models
{
    private List<string> Aromas = new List<string>() 
    {
        "Fruity",
        "Texture",
        "Floral",
        "Vegetal",
        "Spicy",
        "Heat-Induced",
        "Biological" 
    }

    /*
       https://craftbeeracademy.com/beer-characteristics/
    */
    public class Beer
    {
        public string Brewer          { get; set; }
        public string Name            { get; set; }
	public string Color           { get; set; }
	public string Clarity         { get; set; }
        public string Type            { get; set; }
	public double AlcoholByVolume { get; set; }
	public double AlcoholByWeight { get; set; }
	public string Aroma           { get; set; }
    }
}
