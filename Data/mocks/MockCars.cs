using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks {
    public class MockCars : IAllCars {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car { 
                        name = "Tesla Model S", 
                        shortDesc = "Быстрый автомобиль", 
                        lognDesc = "Красивый и очень дорогой автомобиль компании Tesla", 
                        img = "https://avatars.mds.yandex.net/get-pdb/1366122/2fd6de84-65b3-49b9-9f67-031120d15269/s1200", 
                        price = 45000, 
                        isFavourite = true, 
                        available = true, 
                        Category = _categoryCars.AllCategories.First() },
                    new Car {
                        name = "BMW M3",
                        shortDesc = "Дерзкий и стильный",
                        lognDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-pdb/1709021/4b52a6cf-072d-4420-a632-04b0f747d361/s1200?webp=false",
                        price = 20000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last() },
                    new Car {
                        name = "Ford Focus 3 ",
                        shortDesc = "Классика",
                        lognDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-zen_doc/1916740/pub_5d24ad48cfcc8600ada5c63a_5d24c1a1fe289100ac6aa84e/scale_1200",
                        price = 15000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last() },
                    new Car {
                        name = "Ford Focus 1",
                        shortDesc = "Классика",
                        lognDesc = "Удобный автомобиль для городской жизни",
                        img = "https://avatars.mds.yandex.net/get-pdb/1369813/bcd37fe9-f5dd-4219-a45e-11c7285b935c/s1200",
                        price = 15000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last() },
                    new Car {
                        name = "Tesla Model M",
                        shortDesc = "Быстрый автомобиль",
                        lognDesc = "Красивый и дорогой автомобиль компании Tesla",
                        img = "https://www.formacar.com/storage/images/8/8224/07951c487f6b5bc477d0543441581be902.jpg",
                        price = 35000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.First() }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carID) {
            throw new NotImplementedException();
        }
    }
}
