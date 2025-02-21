using System;

namespace UAMS
{

    internal class Program
    {

        static Student StudentPresent(string name)
        {
            foreach (Student s in studentList)
            {
                if (name = s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        static void calculateFeeForAll()
        {
            foreach (Students in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "hass.calculateFee()+ fees");
                }
            }
        }
        static void registerSubjects(Students)
        { 
            Console.WriteLine("Enter how many subjects you want to register"); 
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject Code"); 
                string code Console.ReadLine();
                bool Flag = false;
                foreach (Subject sub in s.regDegree.subjects)
                { 
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {
                        s.regStudentSubject(sub);
                        Flag = true;
                        break;
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }


        static List<Student> sortstudentsByMerit()
        {
            List<Student> sortedStudentList = new List<Student>();
            foreach (Student s in studentList)
            {
                s.calculateMerit();
            }
            sortedStudentList = studentList.OrderByDescending(o => o.merit).ToList();
            return sortedStudentList;
        }
        static void giveAdmission(List<Student> sortedStudentList)
        {
            foreach (Student s in sortedStudentList)
            {
                foreach (DegreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--; 
                        break;
                    }
                }
            }
        }
        static void printstudents()
        {
            foreach (Student s in studentList)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "got Admission in " + s.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(s.name + " did not get Admission");
                }
            }
        }
        static void clearScreen()
        {       
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }        
    }
}