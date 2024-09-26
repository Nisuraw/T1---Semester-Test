using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1___Semester_Test
{
    class File : Thing
    {
        private string _extension;
        private int _size;

        public File(string name, string extension, int size) : base(name)
        {
            _extension = extension;
            _size = size;
        }

        public override int Size()
        {
            return _size;
        }

        public override void print()
        {
            Console.WriteLine($"File: {Name}.{_extension} Size: {_size} bytes ");
        }
    }
}
