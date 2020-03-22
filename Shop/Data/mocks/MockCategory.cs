namespace Shop.Data.mocks
{
    using System.Collections.Generic;
    using Shop.Data.Interfaces;
    using Shop.Data.Models;

    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
          get
            {
                return new List<Category>
                {
                    new Category { name = "Electric", description="tesvfgbfg"},
                    new Category { name = "Classical cars" , description="classic"}
                };
            }
        }
    }
}
