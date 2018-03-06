using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication4
{
    class Filing
    {
        int j = 0, k = 0, d = 0,tmp=0;
        String[] arr = new String[500];
        String[] uniq = new String[500];
        string filename = "C:\\Users\\sohaibaftab\\Desktop\\profile.txt";
        public void insertion(String id, String name, String semseter, float cgpa, String dept, String univ)
        {

            StreamWriter sl = File.AppendText(filename);

            sl.AutoFlush = true;
            sl.WriteLine(id);
            sl.WriteLine(name);
            sl.WriteLine(semseter);
            sl.WriteLine(cgpa);
            sl.WriteLine(dept);
            sl.WriteLine(univ);
            sl.Close();

        }
        public void unique(string idd)
        {
            
            StreamReader re = File.OpenText(filename);

            do
            {
                arr[k] = re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            for (int i = 0; i < k; i++)
            {

                if (arr[i] == idd)
                {

                    Console.WriteLine("Already exist");
                    Environment.Exit(0);
                }
                
                
            }
            re.Close();
        }
        public void top()
        {
             StreamReader re = File.OpenText(filename);
             List<string> gpaList = new List<string>();
             string str;
             do
             {
                 re.ReadLine();
                 re.ReadLine();
                 re.ReadLine();
                 str=re.ReadLine();
                 gpaList.Add(str);
                 re.ReadLine();
                 re.ReadLine();
                 k++;
             }
             while (!re.EndOfStream);
             Array.Reverse(arr);
             gpaList.Sort();
             gpaList.Reverse();
             Console.WriteLine("1: " + gpaList[0]);
             Console.WriteLine("2: " + gpaList[1]);
             Console.WriteLine("3: " + gpaList[2]);

      //foreach (var str in arr)
      //{
      //    Console.WriteLine(str);
      //}
            
        }
        public void search(String searchname)
        {
            StreamReader re = File.OpenText(filename);

            do
            {
                arr[k] = re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            for (int i = 0; i < k; i++)
            {

                if (arr[i] == searchname)
                {
                    Console.WriteLine("Record Found");
                    Console.WriteLine("Your Student ID is:" + arr[i]);
                    Console.WriteLine("Your Name is: " + arr[++i]);
                    Console.WriteLine("Your Smester is: " + arr[++i]);
                    Console.WriteLine("Your CGPA is: " + arr[++i]);
                    Console.WriteLine("Your Department Name is: " + arr[++i]);
                    Console.WriteLine("Your University Name is:" + arr[++i]);

                }


            }
            re.Close();


        }
        public void searchName(String searchname)
        {
            StreamReader re = File.OpenText(filename);

            do
            {
                arr[k] = re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            for (int i = 0; i < k; i++)
            {

                if (arr[i] == searchname)
                {
                    Console.WriteLine("Record Found");
                    Console.WriteLine("Your Student ID is:" + arr[--i]);
                    Console.WriteLine("Your Name is: " + arr[++i]);
                    Console.WriteLine("Your Smester is: " + arr[++i]);
                    Console.WriteLine("Your CGPA is: " + arr[++i]);
                    Console.WriteLine("Your Department Name is: " + arr[++i]);
                    Console.WriteLine("Your University Name is:" + arr[++i]);
                }
                re.Close();

            }
        }
        public void attendence(string atten)
        {
            String[] q = new String[500];
            int t = 0;
            StreamReader re = File.OpenText("C:\\Users\\sohaibaftab\\Desktop\\attendence.txt");

            do
            {
                arr[k] = re.ReadLine();
                k++;
            }
            while (!re.EndOfStream);
            for (int i = 0; i < k; i++)
            {

                if (arr[i] == atten)
                {
                    q[t] = atten;
                    t++;
                    Console.WriteLine(" enter A for absen enter P for present");
                    String ans = Console.ReadLine();
                    if (ans == "p" || ans == "P")
                    {
                        q[t] = "p";
                    }
                    if (ans == "a" || ans == "A")
                    {
                        q[t] = "A";
                    }
                }

            }
            re.Close();
            StreamWriter write = File.AppendText("C:\\Users\\sohaibaftab\\Desktop\\attendence.txt");
            for (int i = 0; i < k; i++)
            {
                write.WriteLine(q[i]);

            }
            write.Close();
        }
        public void viewAttendence()
        {
            StreamReader re = File.OpenText("C:\\Users\\sohaibaftab\\Desktop\\attendence.txt");
            do
            {
                 Console.WriteLine(re.ReadLine());
                
            }
            while (!re.EndOfStream);
        }
        public void delete(string del)
        {

            String[] dee = new String[500];
            StreamReader read = new StreamReader(filename);

            do
            {
                arr[k] = read.ReadLine();
                k++;
            }
            while (!read.EndOfStream);
            for (int i = 0; i < k; i++)
            {
                if (del == arr[i])
                {
                    Console.WriteLine("Record found and Deleted");
                    i = i + 5;

                }
                else
                    dee[d] = arr[i];
                d++;

            }


            read.Close();
            StreamWriter write = File.CreateText(filename);
            for (int i = 0; i < k; i++)
            {
                write.WriteLine(dee[i]);

            }
            write.Close();
        }
        class Program
        {
            static void Main(string[] args)
            {
               //string  filepath = "C:\\Users\\sohaibaftab\\Desktop\\profile.txt";

               string[] arg = new string[0];
               //arg[0]=filepath;
                char c;
                Filing obj = new Filing();
                String Name, Dept, Univ,semster,id;
                 
                int b;
                do
                {
                    Console.WriteLine("\t \t *****Welcome To Sohaib Aftab Rana Profile System*****");
                    Console.WriteLine("1 for Create Student profile");
                    Console.WriteLine("2 for Search Student");
                    Console.WriteLine("3 for Delete Student Record");
                    Console.WriteLine("4 for List top 03 of class");
                    Console.WriteLine("5 for Mark student attendance");
                    Console.WriteLine("6 for View attendance");

                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(b);
                    switch (b)
                    {
                        case 1:
                            Console.WriteLine("Enter id");
                            id=Console.ReadLine();
                            obj.unique(id);
                            String Id = id;
                            Console.WriteLine("Please Enter Your Name ");
                            Name = Console.ReadLine();
                            Console.WriteLine("Please Enter Your Semseter");
                            semster = Console.ReadLine();
                            Console.WriteLine("Please Enter Your CGPA");
                            float Cgpa = float.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter Your Department");
                            Dept = Console.ReadLine();
                            Console.WriteLine("Please Enter Your University");
                            Univ = Console.ReadLine();
                            obj.insertion(Id, Name, semster, Cgpa, Dept, Univ);
                            break;
                        case 2:
                            Console.WriteLine("Enter 1 for Search by id ");
                            Console.WriteLine("Enter 2 for Search by name ");
                            String ans=Console.ReadLine();
                            if (ans == "1")
                            {
                            Console.WriteLine("Please Enter The Student ID");
                            String iid = Console.ReadLine();
                            obj.search(iid);
                            }
                            if (ans == "2")
                            {
                                Console.WriteLine("Please Enter The Student name");
                                String nam= Console.ReadLine();
                                obj.searchName(nam);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Delete Student Record");
                            Console.WriteLine("Please Enter The Student ID");
                            //int del = int.Parse(Console.ReadLine());
                            string del = Console.ReadLine();
                            obj.delete(del);
                            break;
                        case 4:
                            Console.WriteLine("List top 03 of class");
                            obj.top();
                            break;
                        case 5:
                            Console.WriteLine("Mark student attendance");
                            Console.WriteLine("Please Enter The Student ID");
                            String idd = Console.ReadLine();
                            obj.attendence(idd);

                            break;
                        case 6:
                            Console.WriteLine("View attendance");
                            obj.viewAttendence();
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("please enter y for not exit and n for exit");
                    c = char.Parse(Console.ReadLine());
                } while (c == 'y');
            }

        }
    }
}



