using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    /*{
        'pointFrom' : {'text' : "", "x" : 0.0, "y" : 0.0 },
        'pointTo' : {'text' : "",  "x" : 0.0, "y" : 0.0 },
        'inputItems' : [],
        'name' : "",
        'phone' : "",
        'email' : null,
        'movers' : 0,
        'date' : null,
        'timeFrom' : null,
        'timeTo' : null,
        'distance' : 0.0,
        'cost' : 0.0,
        'payed' : false
    }
     */

    public class Point
    {
        public string Text { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
    }

    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Count { get; set; }
    }

    public class UserOrder
    {
        public Point PointFrom { get; set; }
        public Point PointTo { get; set; }
        public List<Item> Items { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Movers { get; set; }
        public string Date { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public string Distance { get; set; }
        public string Cost { get; set; }
        public string Payed { get; set; }
    }
}
