﻿using Glav.CacheAdapter.Bootstrap;

namespace Glav.CacheAdapter.Core
{
    public enum CacheSetting
    {
        Memory,
        Web,
        AppFabric,
        memcached,
        Redis,
        Hybrid
    }

    public static class CacheSettingExtensions
    {
        public static string ToStringType(this CacheSetting cacheSetting)
        {
            switch (cacheSetting)
            {
                case CacheSetting.AppFabric:
                    return CacheTypes.AppFabricCache;
                case CacheSetting.memcached:
                    return CacheTypes.memcached;
                case CacheSetting.Memory:
                    return CacheTypes.MemoryCache;
                case CacheSetting.Redis:
                    return CacheTypes.redis;
                case CacheSetting.Web:
                    return CacheTypes.WebCache;
                case CacheSetting.Hybrid:
                    return CacheTypes.hybrid;
                default:
                    return CacheTypes.MemoryCache;
            }
        }
    }
}
