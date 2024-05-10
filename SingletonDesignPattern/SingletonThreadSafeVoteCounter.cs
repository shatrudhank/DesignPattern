using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal sealed class SingletonThreadSafeVoteCounter
    {
        private static  readonly object _lockobj = new object();

        private int vote  = 0;

        private static SingletonThreadSafeVoteCounter _instance;
        private SingletonThreadSafeVoteCounter() { }

        public static SingletonThreadSafeVoteCounter Instance
        {
            get
            {
                lock (_lockobj)
                {
                    if(_instance==null)
                    {
                        _instance=new SingletonThreadSafeVoteCounter();
                    }
                }
                return _instance;
            }
        }

        public void RegisterVote()
        {
            vote++;
            Console.WriteLine($"Vote Registered {vote}" );
        }

        public int TotalVote => vote;
    }
}
