using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1___Semester_Test
{
    abstract class Thing
    {
        public string Name {  get; private set; }

        public Thing( string name)
        {
            Name = name;
        }

        public abstract int Size();
        public abstract void print();
    }
}
