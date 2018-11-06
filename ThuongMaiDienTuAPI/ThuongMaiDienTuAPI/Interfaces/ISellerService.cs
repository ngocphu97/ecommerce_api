﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Entities;

namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface ISellerService
    {
        Task<object> Get(SellerQuery query);
        Task<Seller> GetByIdUser(int idUser);
    }
}
