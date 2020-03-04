﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks {
    public class MockCategory : ICarsCategory {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categjryName = "Электромобиль", desc = "Современный вид транспорта" },
                    new Category { categjryName = "Классические автомобили", desc = "Машины с дигателем внутреннего сгорания"}
                };
            }
        }
    }
}
