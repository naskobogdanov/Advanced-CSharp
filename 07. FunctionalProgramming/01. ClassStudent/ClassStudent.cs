using System;
using System.IO;
using System.Linq;

class ClassStudent
{
    static void Main()
    {
        StudentsDirectory database = new StudentsDirectory();

        // printing
        database.Students.PrintStudentsInfo();
    }
}