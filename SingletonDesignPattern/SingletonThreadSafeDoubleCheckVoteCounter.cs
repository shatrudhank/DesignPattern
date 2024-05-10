using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal sealed class SingletonThreadSafeDoubleCheckVoteCounter
    {
        private static  readonly object _lockobj = new object();

        private int vote  = 0;

        private static SingletonThreadSafeDoubleCheckVoteCounter _instance;
        private SingletonThreadSafeDoubleCheckVoteCounter() { }

        public static SingletonThreadSafeDoubleCheckVoteCounter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonThreadSafeDoubleCheckVoteCounter();
                        }
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
