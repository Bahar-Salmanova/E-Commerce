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
    [Route("v1/adminusers")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public AdminUserController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] string username, string password)
        {
            
            var admin = await _unitOfWork.AdminUsers.GetFeaturedNameByAdmin(username,password);

            if (admin == null)
            {
                return NotFound();
               
            }

            var adminresource = _mapper.Map<IEnumerable<AdminUser>, IEnumerable<AdminUserResource>>(admin);
           
            return Ok(adminresource);
        }
        
    }
}
