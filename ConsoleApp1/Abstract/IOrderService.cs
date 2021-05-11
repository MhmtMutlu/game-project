using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IOrderService
    {
        void Order(Customer customer, Game game, Campaign campaign);
    }
}
