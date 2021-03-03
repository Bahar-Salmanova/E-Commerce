using AutoMapper;
using Data;
using Data.Entities;
using E_Commerce.Resources;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce.Controllers.V1
{
    [Route("v1/catalogue")]
    [ApiController]
    
    public class CatalogueController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CatalogueController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

       

        [Route("product/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetProduct( [FromQuery] int productId)
        {  
            
            var products = await _unitOfWork.Product.GetDiscountById(productId);
           
            if (products == null)
            {
                return NotFound();
            }
            var productresource = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(products);
               
               return Ok(productresource);
        }/*if (isBanners == null) return BadRequest("Could not find");*/

        [Route("seller")]
        [HttpGet]
        public async Task<IActionResult> GetSeller()
        {
            var seller = await _unitOfWork.Seller.GetAllAsync();
            var sellerresource = _mapper.Map<IEnumerable<Seller>, IEnumerable<SellerResource>>(seller);
            return Ok(sellerresource);
        }
    }
}
