﻿using Basket.API.Models;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<BasketCart> GetBasket(string userName);
        Task<BasketCart> UpdateBasket(BasketCart basketCart);
        Task<bool> DeleteBasket(string userName);
    }
}
