using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InsertData();
        }

        public static void InsertData()
        {
            string details;
            bool t = true;

            while (t)
            {
                Console.WriteLine("Enter a No. to execute:");
                Console.WriteLine("1. Add Student Data");
                Console.WriteLine("2. Add Teacher Data");
                Console.WriteLine("3. Add Subject Data");
                Console.WriteLine("4. Display Data.");
                Console.WriteLine("5. Exit");
                string n = Console.ReadLine();

                if (n == "5")
                {
                    t = false;
                    break;
                }
                switch (n)
                {
                    case "1":
                        if (!File.Exists("C://Users//K_Swati_Subudhi//Desktop//student.txt"))
                        {
                            File.Create("C://Users//K_Swati_Subudhi//Desktop//student.txt");
                        }
                        details = File.ReadAllText("C://Users//K_Swati_Subudhi//Desktop//student.txt");
                        Console.WriteLine("Enter details in this format: StudentId, FirstName, LastName, Standard:");
                        string stu = Console.ReadLine();

                        File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//student.txt", details + "\n" + stu);
                        break;
                    case "2":
                        if (!File.Exists("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt"))
                        {
                            File.Create("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt");
                        }
                        details = File.ReadAllText("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt");
                        Console.WriteLine("Enter details in this format: TeacherId, FirstName, LastName, Subject:");
                        string tea = Console.ReadLine();

                        File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt", details + "\n" + tea);
                        break;
                    case "3":
                        if (!File.Exists("C://Users//K_Swati_Subudhi//Desktop//subject.txt"))
                        {
                            File.Create("C://Users//K_Swati_Subudhi//Desktop//subject.txt");
                        }
                        details = File.ReadAllText("C://Users//K_Swati_Subudhi//Desktop//subject.txt");
                        Console.WriteLine("Enter details in this format: SubjectId, SubjectName, TeacherId:");
                        string sub = Console.ReadLine();

                        string[] subArray = sub.Split(',');
                        List<Subject> list = new List<Subject>();
                        Subject subObj = new Subject();
                        subObj.SubjectId = subArray[0];
                        subObj.SubjectName = subArray[1];
                        subObj.teacherId = subArray[2];
                        list.Add(subObj);

                        //File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//subject.txt", details + "\n" + sub);

                        foreach (Subject s in list)
                            File.WriteAllText("C://Users//K_Swati_Subudhi//Desktop//subject.txt", details + "\n" + s.SubjectId.ToString() +", "+s.SubjectName+", "+s.teacherId);
                        break;

                    case "4":

                        if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//student.txt"))
                        {
                            Console.WriteLine("Student Details::"+"\n");
                            string[] stud = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//student.txt");
                            foreach (string line in stud)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt"))
                        {
                            Console.WriteLine("Teacher Details::" + "\n");
                            string[] teach = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//Teacher.txt");
                            foreach (string line in teach)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        if (File.Exists("C://Users//K_Swati_Subudhi//Desktop//subject.txt"))
                        {
                            Console.WriteLine("Subject Details::" + "\n");
                            string[] subj = File.ReadAllLines("C://Users//K_Swati_Subudhi//Desktop//subject.txt");
                            foreach (string line in subj)
                            {
                                Console.WriteLine(line);
                            }
                        }

                        break;
                    case "5":
                        return;
                }
            }
        }
    }
}
