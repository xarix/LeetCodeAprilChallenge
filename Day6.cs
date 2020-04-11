using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeAprilChallenge
{
    public class Day6
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, List<string>>();
            foreach (var item in strs)
            {
                var str = new string(item.OrderBy(x => x).ToArray());


                if (result.ContainsKey(str)){
                    result[str].Add(item);
                }
                else
                {
                    result.Add(str, new List<string>() { item });
                }
            }
            var r = new List<IList<string>>();

            foreach (var item in result.Values)
            {
                r.Add(item);
            }

            return r;
        }
    }
}
