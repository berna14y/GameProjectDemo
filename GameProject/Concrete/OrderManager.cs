using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;

        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;

        }

        public void ApplyCampaign(Order order, Campaign campaign, Game game)
        {
            decimal campaignService = (decimal)(game.Price - (game.Price * campaign.DiscountRate) / 100);

            if ( game.UnitStock > 0)

               {
                Console.WriteLine(campaign.Name + " applied ");
                Console.WriteLine("Total price: " + campaignService );
                }

                else
                {
                Console.WriteLine("Out of stock.");
                }
            }
    }
}
