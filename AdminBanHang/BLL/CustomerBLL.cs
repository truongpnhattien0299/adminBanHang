﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminBanHang.DTO;

namespace AdminBanHang.BLL
{
    class CustomerBLL
    {
        public DataTable getAllCustomer()
        {
            return DAL.CustomerDAL.getAllCustomer();
        }

    }
}