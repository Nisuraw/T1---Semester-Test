using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1___Semester_Test
{
    class FileSystem
    {
        private List<Thing> _contents = new List<Thing>();

        public void Add(Thing toAdd)
        {
            _contents.Add(toAdd);
        }
        public void PrintContents()
        {
            foreach (Thing item in _contents)
            {
                item.print();
            }
        }
    }
}
