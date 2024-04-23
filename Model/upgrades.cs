using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoopyClicker.Model
{
    internal class upgrades
    {
        public string name { get; set; }
        public string desc { get; set; }
        public int count { get; set; }
        public upgrades(string Name,string Desc,int Count)
        {
            name = Name;
            desc = Desc;
            count = Count;
        }



    }
}
