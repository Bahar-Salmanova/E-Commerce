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
            var customeremail = await _unitOfWork.CustomerUser.GetEmailByCustomer(email);
            if (customeremail == null) return NotFound();
            var customerpassword = await _unitOfWork.CustomerUser.GetPasswordByCustomer(password);
            var customer=_mapper.Map<IEnumerable<CustomerUser>, IEnumerable < CustomerUserResource >> (customeremail);
            return Ok(customer);
        }

    }
}
