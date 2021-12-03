using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace app.Models 
{
    class COLOR 
    {
        public string SRM { get; set; }
        public string RGB { get; set; }
    }

    class BeerColor
    {
        private static List<BeerColor> _colors = null;
        public static List<BeerColor> Colors 
        { 
            get 
            {
                if (_colors == null)
                {
                    string jsonString = System.IO.File.ReadAllText("colors.json");
                    _colors = JsonSerializer.Deserialize<List<BeerColor>>(jsonString);
                }
                return _colors;
            }
        }
        public string Color { get; set; }
        public double SRM { get; set; }
        public string RGB { get; set; }
        public string HEX { get; set; }

        public static BeerColor GetSRM(double srm) 
        {
            srm = Math.Round(srm, 1);
            return Colors.SingleOrDefault(c => c.SRM == srm);
        }
    }
}