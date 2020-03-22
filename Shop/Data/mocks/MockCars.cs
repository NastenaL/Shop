using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
        public IEnumerable<Car> AllCars {
            get
            {
                return new List<Car>
                {
                    new Car {
                        name = "Tesla",
                        shortDescription ="",
                        image ="https://delo.ua/files/news/images/3610/17/picture2_tesla-poluchila-b_361017_p0.jpg",
                        price =42000,
                        available =true,
                        isFavorite =true,
                        Category =categoryCars.AllCategories.First()},
                    new Car {
                        name = "Tesla2",
                        shortDescription ="",
                        image ="https://cdn.forbes.ru/files/presets/900_566/story_images/snimok_ekrana_2019-07-17_v_14.03.35_copy.png__1563361467__98550__vid539847e.png",
                        price =48000,
                        available =true,
                        isFavorite =true,
                        Category =categoryCars.AllCategories.Last()},
                };
                   
                
            }
             }
        public IEnumerable<Car> getFavoriteCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
