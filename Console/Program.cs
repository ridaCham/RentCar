// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

Console.WriteLine("Hello, World!");
CarManager manager = new CarManager(new CarDal());

foreach (Car car in manager.GetAll())
{
    Console.WriteLine(car.Description);

}

Console.WriteLine("Hello, World!");

