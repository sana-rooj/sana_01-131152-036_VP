using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace assignment1VP
{
    class attendance
    {
        public void markAttendance(string path)
        {
             int counter = 0;
             Console.WriteLine("please enter the  class for which you want to mark attendance");
             string classN=Console.ReadLine().ToLower();
            Console.WriteLine("please enter the semester number of department for which you want to mark attendance");
            string classNo=Console.ReadLine();
             var lines = File.ReadAllLines(path);
                 string line = null;//for reading the file lines
                 string[] strArr = null;// for tokenizing the line 
                 string[] info=new string[lines.Length];// for storing new information with attendance
                
                StreamReader file=new StreamReader(path);
                int index = 0;//for information storage indexing
                Console.WriteLine("type p for marking present");
                Console.WriteLine("ENROLLMENT" + "    " + "NAME");
                Console.WriteLine("-------------------------------");
                while ((line = file.ReadLine()) != null)
                {
                        
                        strArr = line.Split(' ');
                     
                        if (strArr[3] == classNo.ToLower() && strArr[2]==classN.ToLower())
                        {
                            Console.WriteLine(strArr[1] + " " + strArr[0]);

                            string mark = Console.ReadLine();
                            if (mark.Equals("p") || mark.Equals("P"))
                            {
                                strArr[5] = "present";//marking the attendance for present students

                                info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " + strArr[5];
                               
                                index++;
                            }
                            else

                            {
                                // for absent student of the searched class
                                info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " + strArr[5];
                               
                                index++;
                            }

                   
                        }
                        else
                        {
                            //for student who do not belong to the serached class
                            info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " + strArr[5];
                            index++;
                            counter++;
                        }


                          
                }
                if (counter == lines.Length)
                    Console.WriteLine("No student to show");
                file.Dispose();
            using (StreamWriter obj=new StreamWriter(path))
            {
                for (int i = 0; i < info.Length; i++)
                {
                    obj.WriteLine(info[i]);
                }
        }

           
                

        }

        public void viewAttendance(string path)
        {
            int counter = 0;
            Console.WriteLine("please enter the semester for which you want to view attendance");
            string classNo = Console.ReadLine();
            string[] strArr = null;
            string line = null;
             var lines = File.ReadAllLines(path);
            StreamReader file = new StreamReader(path);
            Console.WriteLine("ENROLLMENT" + "    " + "NAME"+"    "+"Attendance");
            Console.WriteLine("------------------------------------");
            while ((line = file.ReadLine()) != null)
            {

                strArr = line.Split(' ');

                if (strArr[3] == classNo)
                {
                    Console.WriteLine(strArr[1] + " " + strArr[0] + "      " + strArr[5]);
                }
                else
                    counter++;
            }
            if (counter==lines.Length )
                Console.WriteLine("No student to show");
            file.Dispose();
        }


    }

    
}
