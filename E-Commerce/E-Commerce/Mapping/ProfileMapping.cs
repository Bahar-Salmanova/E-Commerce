using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Entities;
using E_Commerce.Resources;
using E_Commerce.Resources.user;

namespace E_Commerce.Mapping
{
    public class ProfileMapping:Profile
    {
       public ProfileMapping()
        {
            CreateMap<AdminUser, AdminUserResource>();          
            CreateMap<Product, ProductResource > ();
            CreateMap<Seller, SellerResource>();
            CreateMap<CustomerUser, CustomerUserResource>();
            CreateMap<BasketItem, BasketItemResource>();

        }
    }
}
