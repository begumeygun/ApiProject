﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeApi.Application.Interfaces.RedisCache
{
    public interface ICacheablGuery
    {
        string CacheKey {  get; }
        double CacheTime {  get; }
    }
}
