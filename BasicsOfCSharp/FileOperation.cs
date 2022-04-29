using System;
using System.Collections.Generic;
using System.IO;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    class FileOperation
    {
        public void WriteFile()
        {
            string content = "Name, ID, Dept";
            File.WriteAllText("D://employee.txt", content);
        }

        public void UpdateFile()
        {
            string employee = Environment.NewLine+"JonDoe, 1, Finance";
            File.AppendAllText("D://employee.txt", employee);
        }

        public void ReadFile()
        {
            string content = File.ReadAllText("D://employee.txt");
            Console.WriteLine(content);
            string[] contents = File.ReadAllLines("D://employee.txt");
            foreach(string employee in contents)
            {   
                // "1, Jon, Finance".split(",") => ["1", "Jon", "Finance"]
                string id = employee.Split(",")[0];
                Console.WriteLine(id);
            }
        }

        public void DeleteFile()
        {
            if(File.Exists("D://employee.txt")){
                File.Delete("D://employee.txt");
            }
        }
    }
}

// Create a program to accept studen'ts details.
// Store details into file.
// Allow update of student in file.
// Allow delete of a student n file.

// 1. Add data, 2. Update Data, 3. Delete, 4. Display, 5. Exit.
// (ID, name, dept).
// (ID, name, dept). // update name and dept.
// 3. ID

// Reading, Writing console.
// loops, conditions.
// file operations.