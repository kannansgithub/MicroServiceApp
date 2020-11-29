using Basket.API.Data.Interfaces;
using Basket.API.Models;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IBasketContext _basketContext;
        public BasketRepository(IBasketContext basketContext)
        {
            _basketContext = basketContext ?? throw new ApplicationException(nameof(basketContext));
        }
        public async Task<BasketCart> GetBasket(string userName)
        {
            var basket = await _basketContext.Redis.StringGetAsync(userName);
            return basket.IsNullOrEmpty ? new BasketCart(userName) : JsonConvert.DeserializeObject<BasketCart>(basket);
        }
        public async Task<BasketCart> UpdateBasket(BasketCart basketCart)
        {
            var basketResult = await _basketContext.Redis.StringSetAsync(basketCart.UserName, JsonConvert.SerializeObject(basketCart));
            return basketResult ? await GetBasket(basketCart.UserName) : new BasketCart(basketCart.UserName);
        }
        public async Task<bool> DeleteBasket(string userName)
        {
            return await _basketContext.Redis.KeyDeleteAsync(userName);
        }




    }
}
