using AutoMapper;
using Data;
using Data.Entities;
using E_Commerce.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
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



        [Route("product")]
        [HttpGet]
        public async Task<IActionResult> GetProduct()
        {
            try
            {
                var products = await _unitOfWork.Product.GetAllAsync();
                var productsserource = _mapper.Map<IEnumerable<Product>, IEnumerable < ProductResource >> (products);
                return Ok(productsserource);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> Get(int productId)
        {
            try
            {
                var product = await _unitOfWork.Product.GetByIdAsync(productId);


                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        } 
   
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
