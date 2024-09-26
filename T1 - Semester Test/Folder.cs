using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1___Semester_Test
{
    class Folder : Thing
    {
        private List<Thing> _contents = new List<Thing>();

        public Folder(string name) : base(name) { }

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }

        public override int Size()
        {
            int totalSize = 0;
            foreach (Thing item in _contents)
            {
                totalSize += item.Size();
            }
            return totalSize;
        }

        public override void print()
        {
            Console.WriteLine($"Folder: {Name}");
            foreach (Thing item in _contents)
            {
                item.print();
            }
        }
    }
}
