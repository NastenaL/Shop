namespace Shop.Data.Interfaces
{
    using Shop.Data.Models;
    using System.Collections.Generic;
    interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; set; }
    }
}
