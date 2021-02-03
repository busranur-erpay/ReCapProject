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
            
             new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50,Description="A",ModelYear=2010},
             new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=150,Description="B",ModelYear=2000},
             new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=100,Description="C",ModelYear=2005},
             new Car{Id=4,BrandId=2,ColorId=4,DailyPrice=220,Description="D",ModelYear=2015},
             new Car{Id=5,BrandId=3,ColorId=5,DailyPrice=250,Description="E",ModelYear=2012},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id); 

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);


            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
           
        }
    }
}
