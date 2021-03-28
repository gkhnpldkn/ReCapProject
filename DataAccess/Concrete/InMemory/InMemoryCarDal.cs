using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
             new Car { Id =1,ColorId = 1, BranId = 1, DailyPrice= 150, ModelYear = 2019, Description ="dizel otomatik"},
             new Car { Id =2,ColorId = 1, BranId = 2, DailyPrice= 100, ModelYear = 2020, Description ="benzinli otomatik"},
             new Car { Id =3,ColorId = 2, BranId = 1, DailyPrice= 80, ModelYear = 2018, Description ="dizel manuel"},
             new Car { Id =4,ColorId = 2, BranId = 3, DailyPrice= 70, ModelYear = 2017, Description ="benzinli manuel"},
             new Car { Id =5,ColorId = 3, BranId = 4, DailyPrice= 40, ModelYear = 2003, Description ="lpg'li"},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BranId = car.BranId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
