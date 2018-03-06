using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace assignment1VP
{
    class studentProfile
    {
        public void createfile(string path)
        {

            using (StreamWriter obj = new StreamWriter(path))
            {
                obj.WriteLine("sana 01-131152-036 bsse 6 3.9 absent");
                obj.WriteLine("misha 01-131152-016 bsce 6 3.8 absent");
                obj.WriteLine("fiza 01-131152-001 bsse 6 3.3 absent");
                obj.WriteLine("hamza 01-131152-016 bsse 7 3.5 absent");
                obj.WriteLine("fiza 01-131152-026 bsse 6 3.5 absent");

                obj.Dispose();
            }

        }

        public void enterStudent(string name, string enroll, string degree, int semester, float cgpa, string attendence, string path)
        {

            StreamReader file = new StreamReader(path);
            string line;
            Boolean enable = true;
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(enroll) == true)
                {
                    Console.WriteLine("sorry this enrollment can not be alloted");
                    enable = false;
                }


            }
            file.Dispose();
            if (enable == true)
            {
                using (StreamWriter sw = File.AppendText(path))//to append the data at the end of text file
                {


                    sw.WriteLine(name + " " + enroll + " " + degree + " " + semester + " " + cgpa + " " + attendence);
                    sw.Dispose();
                }
                Console.Write("\t");
                Console.WriteLine("data successfully written");
            }



        }
        public void checkname(string name, string path)
        {
            string line;
            int counter = 0;
            var lines = File.ReadAllLines(path);
            
            Console.WriteLine("name" + " " + "enroll" + "     " + "degree" + " " + "sem" + " " + "cgpa" + " " + "attendance");
            Console.WriteLine("----------------------------------------------------");
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(name) == true)
                {
                    Console.WriteLine(line);


                }
                else
                    counter++;
            }
            if (counter == lines.Length)
                Console.WriteLine("sorry no student found");
            file.Dispose();

        }
        public void checkEnroll(string enroll, string path)
        {
            string line;
            int counter = 0;
            var lines = File.ReadAllLines(path);
            // Read the file and display it line by line.
            Console.WriteLine("name" + " " + "enroll" + "     " + "degree" + " " + "sem" + " " + "cgpa" + " " + "attendance");
            Console.WriteLine("----------------------------------------------------");
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(enroll) == true)
                {
                    Console.WriteLine(line);


                }
                else
                    counter++;

            }

            if (counter == lines.Length)
                Console.WriteLine("sorry no student found");
            file.Dispose();

        }
        public void checkSemester(int semester, string path)
        {
            string line;
            string[] strArr = null;
            int counter = 0;// for indexing students
            string sem = semester.ToString();
            Console.WriteLine("  " + "name" + " " + "enroll" + "     " + "degree" + " " + "sem" + " " + "cgpa" + " " + "attendance");
            Console.WriteLine("----------------------------------------------------");
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                strArr = line.Split(' ');

                if (strArr[3] == sem)
                {
                    counter++;
                    Console.WriteLine(counter + "-" + line);
                }

            }
            if (counter == 0)
                Console.WriteLine("sorry no student to show");
            file.Dispose();

        }
      
        public void deleteRecord(string enroll, string path)
        {

            var lines = File.ReadAllLines(path);
            string[] updated = new string[lines.Length];
            int i = 0;
            foreach (var line in lines)
            {
                if (lines[i].Contains(enroll) == true)
                    i++;//skiping that index
                else
                {
                    updated[i] = lines[i];//store it in updated array
                    i++;
                }
            }

            StreamWriter fileW = new StreamWriter(path);
            int j = 0;

            using (fileW)
            {
                while (j < updated.Length)
                {
                    fileW.WriteLine(updated[j]);//rewrite the file with updated data
                    j++;
                }



            }


            fileW.Dispose();
            // for removing the blank space created because of deleting rows
            string[] text = File.ReadAllLines(path).Where(s => s.Trim() != string.Empty).ToArray();
            File.Delete(path);
            File.WriteAllLines(path, text);


        }
        public void searchGpa(string cgpa, string path)
        {
            string line;

            // Read the file and display it line by line.

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(cgpa) == true)
                {
                    Console.WriteLine(line);


                }

            }
            file.Dispose();
        }


        public void topers(string path)
        {


            var lines = File.ReadAllLines(path);
            string[] strArr = null;
            string[] cgpa = new string[lines.Length];
            string line = null;
            StreamReader file = new StreamReader(path);
            int i = 0;
            while ((line = file.ReadLine()) != null)
            {
                strArr = line.Split(' ');
                for (int count = 0; count < strArr.Length; count++)
                {
                    if (strArr[count].Contains("."))
                    {
                        cgpa[i] = strArr[count];
                        i++;
                    }
                }

            }
            file.Dispose();
            string[] unicgpa = cgpa.Distinct().ToArray();//getting unique top three gpa
            var topThree = (from gpa in unicgpa
                            orderby gpa descending
                            select gpa).Take(3);

            foreach (var x in topThree)
            {
                searchGpa(x, path);//show info of students with top three gpa
            }


        }

        static void Main(string[] args)
        {
            string path = args[0];
       
            studentProfile obj1 = new studentProfile();
            obj1.createfile(path);
            attendance obj = new attendance();
            string choice = null;
            do
            {
                Console.WriteLine("please enter the choice of operation you want to perform");
                Console.WriteLine("\t" + "press 1- for entering a new student");
                Console.WriteLine("\t" + "press 2- searching a student ");
                Console.WriteLine("\t" + "press 3- for deleting a students record");
                Console.WriteLine("\t" + "press 4- for showing toppers");
                Console.WriteLine("\t" + "press 5- for marking attendance student");
                Console.WriteLine("\t" + "press 6- for showing attendance");
                string choiceFunc = null;
                choiceFunc = Console.ReadLine();
                switch (choiceFunc)
                {
                    case "1":
                        {
                            string name, enroll, dep, semester, cgpa, attendance = null;
                            Console.WriteLine("\t please enter the first name");
                            Console.Write("\t");
                            name = Console.ReadLine().ToLower();
                            Console.WriteLine("\t enter enrollment in format **-******-***");
                            Console.Write("\t");
                            enroll = Console.ReadLine();
                            Console.WriteLine("\t enter department as (bs--)");
                            Console.Write("\t");
                            dep = Console.ReadLine().ToLower();
                            Console.WriteLine("\t enter semester number");
                            Console.Write("\t");
                            semester = Console.ReadLine();
                            int semesterVal = Convert.ToInt32(semester);
                            Console.WriteLine("\t enter cgpa upto one floating point");
                            Console.Write("\t");
                            cgpa = Console.ReadLine();
                            float cgpaVal = float.Parse(cgpa);
                            Console.WriteLine("\t enter attendance status as present or absent");
                            Console.Write("\t");
                            attendance = Console.ReadLine();
                            obj1.enterStudent(name, enroll, dep, semesterVal, cgpaVal, attendance, path);
                            break;
                        }
                    case "2":
                        {
                            string searchChoice = null;
                            Console.WriteLine("please enter the pattern for searching student");
                            Console.WriteLine("\t press 1- for by name searching");
                            Console.WriteLine("\t press 2- for by enrollment searching as **-******-***");
                            Console.WriteLine("\t press 3- for by semeter searching number");
                            searchChoice = Console.ReadLine();
                            if (searchChoice == "1")
                            {
                                Console.WriteLine("\t please enter the first name for searching");
                                Console.Write("\t");
                                string name = Console.ReadLine().ToLower();
                                obj1.checkname(name, path);
                            }
                            else if (searchChoice == "2")
                            {
                                Console.WriteLine("\t please enter the enrollment for searching in format **-******-***");
                                Console.Write("\t");
                                string enroll = Console.ReadLine();
                                obj1.checkEnroll(enroll, path);
                            }
                            else if (searchChoice == "3")
                            {
                                Console.WriteLine("\t please enter the semester number for searching");
                                Console.Write("\t");
                                string semester = Console.ReadLine();
                                int semesterVal = Convert.ToInt32(semester);
                                obj1.checkSemester(semesterVal, path);
                            }
                            else
                                Console.WriteLine("invalid chocie");

                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\t please enter the enrollment for deleting data in format **-******-***");
                            Console.Write("\t");
                            string enroll = Console.ReadLine();
                            obj1.deleteRecord(enroll, path);
                            break;

                        }
                    case "4":
                        {
                            obj1.topers(path);
                            break;

                        }
                    case "5":
                        {
                            obj.markAttendance(path);
                            break;
                        }
                    case "6":
                        {
                            obj.viewAttendance(path);
                            break;
                        }
                    default:
                        Console.WriteLine(" \t invalid choice");
                        break;




                }
                Console.WriteLine("\t do you want to continue? \n \t press y for yes");
                Console.Write("\t");
                choice = Console.ReadLine();


            } while (choice.Equals("y") || choice.Equals("Y"));


        }
    }

        
}
