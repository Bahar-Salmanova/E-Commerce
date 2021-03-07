using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Entities;
using E_Commerce.Resources;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ShoppingController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet("GetBasketItems/{adminUserId}")]
        public async Task<IActionResult> GetBasketItems(int adminUserId)
        {
           var basketItems = await _unitOfWork.BasketItem.GetBasketItemsAsync(adminUserId);

            var basketitemresource = _mapper.Map<IEnumerable<BasketItem>, IEnumerable<BasketItemResource>>(basketItems);
            return Ok(basketitemresource);
        }

        // POST api/ShoppingCart
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] BasketItem basketItem)
        {
            var basketitem=await _unitOfWork.BasketItem.AddItemintoBasketAsync(basketItem);

            var basketitemresource = _mapper.Map<IEnumerable<BasketItem>, IEnumerable<BasketItemResource>>(basketitem);

            return Created($"shoppingCart", basketitemresource);
            
        }

        // PUT api/ShoppingCart/ChangeItemQuantity/5/4
        [HttpPut("ChangeItemQuantity/{basketItemId}/{quantity}")]
        public async Task<IActionResult> ChangeItemQuantity(int basketItemId, int quantity)
        {
            var basketItems = await _unitOfWork.BasketItem.ChangeBasketItemQuantityAsync(basketItemId, quantity);


            if (basketItems == null)

                return NotFound("Item not found in the basket, please check the basketItemId");
            var basketitemresource = _mapper.Map<IEnumerable<BasketItem>, IEnumerable<BasketItemResource>>(basketItems);


            return Ok(basketitemresource);

        }

        // DELETE api/ShoppingCart/ClearBasket/1
        [HttpDelete("ClearBasket/{userId}")]
        public async Task<IActionResult> ClearBasket(int adminuserId)
        {
            var basketItems = await _unitOfWork.BasketItem.ClearBasketAsync(adminuserId);
            var basketitemresource = _mapper.Map<IEnumerable<BasketItem>, IEnumerable<BasketItemResource>>(basketItems);


            return Ok(basketitemresource);

        }

    }
}
