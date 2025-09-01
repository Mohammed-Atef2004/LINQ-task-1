using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_task_1
{
    public class LINQ_methods
    {
        public static IEnumerable<T> Where<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                //print doesn't represent the actual functionality of where in LINQ so I used list to store the result
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }


        public static IEnumerable<T> WhereIndex<T>(IEnumerable<T> source, Func<T, int, bool> predicate)
        {
            List<T> result = new List<T>();
            int index = 0;
            foreach (var item in source)
            {
                if (predicate(item, index))
                {
                    result.Add(item);
                }
                index++;
            }
            return result;
        }
        public static IEnumerable<TResult> Select<T, TResult>(IEnumerable<T> source, Func<T, TResult> selector)
        {
            List<TResult> result = new List<TResult>();
            foreach (var item in source)
            {
                result.Add(selector(item));
            }
            return result;
        }
        public static IEnumerable<TResult> SelectIndex<T, TResult>(IEnumerable<T> source, Func<T, int, TResult> selector)
        {
            List<TResult> result = new List<TResult>();
            int index = 0;
            foreach (var item in source)
            {
                result.Add(selector(item, index));
                index++;
            }
            return result;
        }
        public static IEnumerable<T> Skip<T>(IEnumerable<T> source, int count)
        {
            List<T> result = new List<T>();
            int index = 0;
            foreach (var item in source)
            {
                if (index >= count)
                {
                    result.Add(item);
                }
                index++;
            }
            return result;
        }
        public static IEnumerable<T> Take<T>(IEnumerable<T> source, int count)
        {
            List<T> result = new List<T>();
            int index = 0;
            foreach (var item in source)
            {
                if (index < count)
                {
                    result.Add(item);
                }
                index++;
            }
            return result;
        }
        public static IEnumerable<T> takeLast<T>(IEnumerable<T> source, int count)
        {
            List<T> result = new List<T>();
            int totalCount = source.Count();
            int index = 0;
            foreach (var item in source)
            {
                if (index >= totalCount - count)
                {
                    result.Add(item);
                }
                index++;
            }
            return result;
        }
        public static IEnumerable<T> skipLast<T>(IEnumerable<T> source, int count)
        {
            List<T> result = new List<T>();
            int totalCount = source.Count();
            int index = 0;
            foreach (var item in source)
            {
                if (index < totalCount - count)
                {
                    result.Add(item);
                }
                index++;
            }
            return result;
        }
        public static IEnumerable<T> TakeWhile<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            //break is the key difference between where and takeWhile
            List<T> result = new List<T>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
                else
                {
                    break;
                }
            }
            return result;
        }
        public static IEnumerable<T> SkipWhile<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            bool shouldSkip = true;
            foreach (var item in source)
            {
                if (shouldSkip && predicate(item))
                {
                    continue;
                }
                else
                {
                    shouldSkip = false;
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
