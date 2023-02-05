﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Common.DBHelper;
using WebBanHang.Common.Entities.Model;
using WebBanHang.Common.Interfaces.DL;
using WebBanHang.Common.ServiceCollection;
using WebBanHang.DL.BaseDL;

namespace WebBanHang.DL.DL
{
    public class RoleDL : BaseDL<Role>, IRoleDL
    {
        public RoleDL(IConfiguration configuration, IDBHelper dbHelper) : base(configuration, dbHelper)
        { 
        }

    }
}
