using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager(new NewRStateUserValidationManager());

            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Aslı",
                LastName = "Yılmaz",
                BirthYear = 1996,
                NationalityId = 12345,
            };

            Personnel personnel = new Personnel
            {
                Id = 2,
                FirstName = "Berna",
                LastName = "Kara",
                BirthYear = 1990,
                NationalityId = 13564,
                Department = "Sales",
                City = "Ankara",
            };

            manager.Add(gamer);
            manager.Delete(gamer);
            manager.Update(gamer);

            manager.Add(personnel);
            manager.Delete(personnel);
            manager.Update(personnel);

            Console.ReadLine();

            Game game = new Game { Id = 5, Name = "League of Legends", Price = 200, UnitStock = 50 };

            Campaign campaign = new Campaign { Id = 51, Name = "Black Friday", DiscountRate = 40 };

            Order order = new Order { Id = 12, OrderCode = 1589 };

            OrderManager orderManager = new OrderManager(new CampaignManager());

            orderManager.ApplyCampaign(order, campaign, game);

        }
    }
}


