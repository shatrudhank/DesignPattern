using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> nums = Enumerable.Range(0, 10);
            // Not thread Safe
            SingletonUser singletonUser1=SingletonUser.Instance;
            singletonUser1.User++;

            SingletonUser singletonUser2 = SingletonUser.Instance;
            singletonUser2.User++;

            Console.WriteLine( singletonUser1.User);

            //Thread Safe

            Parallel.ForEach(nums, (x) =>
            {
                SingletonThreadSafeVoteCounter singletonThreadSafeVoteCounter = SingletonThreadSafeVoteCounter.Instance;
                singletonThreadSafeVoteCounter.RegisterVote();
           });
            SingletonThreadSafeVoteCounter singletonThreadSafeVoteCounter1 = SingletonThreadSafeVoteCounter.Instance;
            Console.WriteLine($"Thread Safe {singletonThreadSafeVoteCounter1.TotalVote}");

        }
    }
}
