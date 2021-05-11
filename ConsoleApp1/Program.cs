using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Mehmet",
                LastName = "Mutlu",
                NationalityId = "12345678910",
                DateOfBirth = new DateTime(1997, 3, 17)
            };
            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter());
            customerManager.Save(customer1);

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Counter-Strike Global Offensive",
                GamePrice = 79
            };
            GameManager gameManager = new GameManager();
            gameManager.Save(game1);

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Summer Sale",
                DiscountRate = 20
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Save(campaign1);

            OrderManager orderManager = new OrderManager();
            orderManager.Order(customer1, game1, campaign1);
        }
    }
}
