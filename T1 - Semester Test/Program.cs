using System;
using System.Collections.Generic;


namespace T1___Semester_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentID = "104921383";
            int[] A = { 2, 3, 5, 7, 11, 13, 17, 19, 23};
            int[] B = { A[1], A[3], A[8], A[3] };

            FileSystem fs = new FileSystem();

            for (int i = 0; i < B[0]; i++)
            {
                fs.Add(new File($"{studentID}-{i}", "txt", 100));
            }

            Folder folder1 = new Folder("Documents");
            for (int i = 0;i < B[1]; i++)
            {
                folder1.Add(new File($"{studentID}-Doc{i}", "txt", 200));
            }
            fs.Add(folder1 );

            Folder subFolder = new Folder("Nested");
            for(int i = 0; i<B[2]; i++)
            {
                subFolder.Add(new File($"studentID- Sub{i}", "txt", 300));
            }
            Folder mainFolder = new Folder("Main");
            mainFolder.Add(subFolder);
            fs.Add(mainFolder);

            for (int i = 0; i < B[3]; i++)
            {
                fs.Add(new Folder($"EmptyFolder - {i}"));
            }

            fs.PrintContents();
        }
    }
}
