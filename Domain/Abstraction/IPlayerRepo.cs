﻿using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IPlayerRepo
    {
        void Insert(Player pPlayer);
    }
}
