using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignIn_SignUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\UET-CS24\\S2\\OOP\\Week1\\Lab_Manual_1\\Sign_System\\SignIn-SignUp\\credentials.txt";
            string[] names = new string[10];
            string[] password = new string[10];
            int op = 0;
            while (op < 3)
            {
                loadData(path, names, password);
                op = menu();
                if (op == 1)
                {
                    Console.Write("Enter your name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string p = Console.ReadLine();
                    signin(n, p, names, password);
                }
                if( op == 2)
                {
                    Console.Write("Enter new name: ");
                    string n = Console.ReadLine();
                    Console.Write("Enter new password: ");
                    string p = Console.ReadLine();
                    signup(path, n, p);
                }
            }
        }
        static int menu()
        {
            Console.Clear();
            int option;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("Enter any other number to exit.");
            Console.Write("Select Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
            Console.Clear();
        }
        static void signup(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
        static void signin(string n, string p, string[] names, string[] password)
        {
            bool flag = false;
            for (int i = 0; i < 10; i++)
            {
                if (n == names[i] && p == password[i])
                {
                    Console.WriteLine("Valid Credentails");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid Credentails");
            }
            Console.ReadKey();
        }

        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static void loadData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Do not exist.");
            }
        }
    }
}
