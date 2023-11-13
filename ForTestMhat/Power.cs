using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTestMhat
{
    internal class Power
    {
        private int basic;
        private int exp;

        public int GetBasic()
        {
            return basic;
        }
        public int GetExp()
        {
            return exp;
        }
        public void SetBasic(int basic)
        {
            this.basic = basic;
        }
        public void SetExp(int exp)
        {
            this.exp = exp;
        }

    }
}
