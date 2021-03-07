using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Data.Entities;
using E_Commerce.Resources;
using E_Commerce.Resources.user;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers.V1
{
    [Route("v1/customeruser")]
    [ApiController]
    public class CustomerUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CustomerUserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody]string email,string password)
        {
            var customer = await _unitOfWork.CustomerUser.GetEmailByCustomer(email,password);
            if (customer! == null)
            {
                return NotFound();
            }
            var customerresource=_mapper.Map<IEnumerable<CustomerUser>, IEnumerable < CustomerUserResource >> (customer);
            return Ok(customerresource);
        }

    }
}
