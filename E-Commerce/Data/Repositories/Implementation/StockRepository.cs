﻿using Data.Entities;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories.Implementation
{
   public class StockRepository:Repository<Stock>, IStockRepository
    {public StockRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
