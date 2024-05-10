using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    internal sealed class SingletonUser
    {
        private static SingletonUser instance;

        public  int User {  get; set; }
        private SingletonUser() { }

        public static SingletonUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance=new SingletonUser();
                }
                return instance;
            }
        }
    }
}
