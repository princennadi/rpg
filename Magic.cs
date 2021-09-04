using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Magic
    {
        private string name;
        private int totalMana;
        private int manaUsed;

        public Magic(string name, int totalMana, int manaUsed)
        {
            this.name = name;
            this.totalMana = totalMana;
            this.manaUsed = manaUsed;


        }

        public virtual int passiveMagic()
        {
            return 0;
        }

        public virtual int activeMagic()
        {
            return 1;
        }

    }
}
