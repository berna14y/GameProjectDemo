using GameProject.Abstract;
using GameProject.Entities;
using System;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign updated."); ;
        }
    }
}
