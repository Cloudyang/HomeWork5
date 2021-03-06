﻿using System.Collections.Generic;

namespace Common
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> CheckNull<T>(this IEnumerable<T> list)
        {
            return list ?? new List<T>();
        }
    }
}