namespace Shop.Data.Models
{
    using System.Collections.Generic;
    public class Category
    {
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public List<Car> Cars { set; get; }
    }
}
