using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemoryDal;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var item in carManager.GetCarsByColorId(2))
{
    Console.WriteLine("Araç adı :"+item.CarName+" / Günlük fiyat: "+item.DailyPrice+" / Açıklama :"+item.Description);
}

/*foreach (var item in carManager.GetById(2))
{
    Console.WriteLine("Araç ID'si :" + item.CarId + " / Günlük fiyat: " + item.DailyPrice + " / Arabanın model yılı :" + item.ModelYear);
}*/
Console.ReadKey();