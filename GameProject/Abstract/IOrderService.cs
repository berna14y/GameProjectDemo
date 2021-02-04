using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void ApplyCampaign(Order order, Campaign campaign, Game game);
    }
}
