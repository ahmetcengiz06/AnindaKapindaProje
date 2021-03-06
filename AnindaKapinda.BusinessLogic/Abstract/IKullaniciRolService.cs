﻿using AnindaKapinda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnindaKapinda.BusinessLogic.Abstract
{
   public interface IKullaniciRolService: IBaseService<KullaniciRol>
    {
        KullaniciRol GetRoleByName(string ad);
    }
}
