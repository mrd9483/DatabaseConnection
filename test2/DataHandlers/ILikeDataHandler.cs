﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    public interface ILikeDataHandler
    {
        List<ppLikes> GetLike(int nomid);
        int CreateLike(int nomid);
    }
}
