namespace Shop.Data.Interfaces
{
    using Shop.Data.Models;
    using System.Collections.Generic;

    interface IAllCars
    {
        IEnumerable<Car> AllCars { get;}
        IEnumerable<Car> getFavoriteCars { get; set; }
        Car getObjectCar(int carId);
    }
}
