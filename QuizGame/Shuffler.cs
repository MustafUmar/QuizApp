using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class Shuffler
    {
        
        public static void Shuffle()
        {
            var rnd = new Random();
            //int[]nums = new int[]{1,2,3,4,5,6,7,8};
            var list = new List<string>() { "Anna", "Bella", "Charles", "Dan", "Earl", "Fred" };

            list.OrderBy(x => rnd.Next()).ToList();
            //return nums.OrderBy(x => rnd.Next()).ToArray();
            
            //return Enumerable.Range(0, 7).OrderBy(x => rnd.Next()).ToArray();

            //var rnd = new Random();
            //var nums = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    var r = rnd.Next(0, i + 1);
            //    if (i != r)
            //        nums[i] = nums[r];
            //    nums[r] = nums[i];
            //}
            //return nums;
        }
    }
}
