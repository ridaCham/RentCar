// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

Console.WriteLine("Hello, World!");
CarManager manager = new CarManager(new CarDal());

UserManager userManager = new UserManager(new UserDal());

//UserTest(userManager);
//NewMethod1(manager);
//NewMethod0(manager);

static void NewMethod0(CarManager manager)
{
    Car Car = new Car();
    Car.Name = "Togg";
    Car.Id = 11;
    Car.DailyPrice = 2055;
    Car.ModelYear = 2023;
    Car.ColorId = 4;
    Car.BrandId = 3;
    Car.Description = "TOGG 2023 MODEL TO RENT";
    //manager.Add(Car);
    Car Car1 = new Car();
    Car1.Id = 6;
    manager.Delet(Car1);


    foreach (Car car in manager.GetAll().Data)
    {
        Console.WriteLine(car.Description + "///" + car.Id);

    }
    Console.WriteLine("Hello, World!");
}

static void NewMethod1(CarManager manager)
{
    foreach (var car in manager.GetCarsDetails().Data)
    {
        Console.WriteLine(car.CarName + "///" + car.ColorName);
    }
}

static void UserTest(UserManager userManager)
{
    User User1 = new User();
    User User2 = new User();
    User1.FirstName = "Ali";
    User1.LastName = "Jekany";
    User1.Email = "ALi@jekany.net";

    User2.FirstName = "Rıza";
    User2.LastName = "Cheik";
    User2.Email = "Riza@jekany.net";
    Console.WriteLine(userManager.Add(User1));
    Console.WriteLine(userManager.Add(User2));
}