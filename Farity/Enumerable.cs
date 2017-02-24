﻿using System.Collections.Generic;
using System.Linq;

namespace Farity
{
    public static partial class F
    {

        public static IEnumerable<T> Sort<T>(IEnumerable<T> source) => source.OrderBy(x => x);

        public static IEnumerable<T> Unique<T>(IEnumerable<T> source) => source.Distinct();

        public static IEnumerable<T> DefaultTo<T>(T value, IEnumerable<T> source) => source.DefaultIfEmpty(value);

        public static T First<T>(IEnumerable<T> source) => source.First();

        public static T Last<T>(IEnumerable<T> source) => source.Last();
    }
}