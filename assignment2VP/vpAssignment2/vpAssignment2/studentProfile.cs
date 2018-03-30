using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace vpAssignment2
{
    class studentProfile
    {
        public void createfile()
        {

            string[] arr = new string[5];
            arr[0] = "sana 01-131152-036 bsse 6 3.9 absent";
            arr[1] = "misha 01-131152-016 bsce 6 3.8 absent";
            arr[2] = "fiza 01-131152-001 bsse 6 3.3 absent";
            arr[3] = "hamza 01-131152-016 bsse 7 3.5 absent";
            arr[4] = "fiza 01-131152-026 bsse 6 3.5 absent";
            dataOperation.dataProperty.write(arr);

        }

        public void enterStudent(string name, string enroll, string degree, int semester, float cgpa, string attendence)
        {

            string[] read = dataOperation.dataProperty.read();
            int i = 0;
            Boolean enable = true;
            while (i < read.Length)
            {
                if (read[i++].Contains(enroll) == true)
                {
                    MessageBox.Show("sorry this enrollment can not be alloted");
                    enable = false;
                }


            }

            if (enable == true)
            {
                string[] write = new string[1];
                write[0] = name + " " + enroll + " " + degree + " " + semester + " " + cgpa + " " + attendence;
                dataOperation.dataProperty.Append(write);

                MessageBox.Show("data successfully written");
            }

        }
        public string[] checkRecord(string name)
        {
            string[] arr = dataOperation.dataProperty.read();
            int i = 0;
            int counter = 0;
            string[] result = new string[arr.Length];
            while (i < arr.Length)
            {

                if (arr[i].Contains(name) == true)
                {
                    result[i]=arr[i];


                }
                else
                    counter++;
                i++;
            }
            if (counter == arr.Length)
                MessageBox.Show("sorry no student found");
            string[] resultVal = result.Where(r => !string.IsNullOrEmpty(r)).ToArray();
            return resultVal;

        }
        public string[] checkSemester(int semester)
        {
            string[] arr = dataOperation.dataProperty.read();
            int i = 0;
            string[] result = new string[arr.Length];
            string[] strArr = null;
            int counter = 0;// for indexing students
            string sem = semester.ToString();

            while (i < arr.Length)
            {
                strArr = arr[i].Split(' ');

                if (strArr[3] == sem)
                {
                    counter++;
                    result[i]=counter + " " + arr[i];
                }
                i++;

            }
            if (counter == 0)
                MessageBox.Show("sorry no student to show");
            string[] resultVal = result.Where(r => !string.IsNullOrEmpty(r)).ToArray();
            return resultVal;

        }

        public void deleteRecord(string enroll)
        {

            string[] arr = dataOperation.dataProperty.read();
            string[] updated = new string[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i].Contains(enroll) == false)
                {
                    updated[j] = arr[i];
                    j++;

                }


            }
            MessageBox.Show("data successfully delelted");
            updated = dataOperation.dataProperty.trimMethod(updated);
            dataOperation.dataProperty.write(updated);
        }
        public string[] searchGpa(string[] cgpa)
        {
            string[] arr = dataOperation.dataProperty.read();
            int i = 0;
            int j = 0;
            string[] result = new string[arr.Length];
            while (i < arr.Length)
            {
               
                    if (arr[i].Contains(cgpa[0]) || arr[i].Contains(cgpa[1]) || arr[i].Contains(cgpa[2]) == true)
                    {
                        result[j++] = arr[i];


                    }
                    i++;
              
            }
            result = result.Where(r => !string.IsNullOrEmpty(r)).ToArray();
            return result;


        }


        public string[] topers()
        {

            string[] arr = dataOperation.dataProperty.read();
            string[] resultLine = new string[arr.Length];
            string[] strArr = null;
            string[] cgpa = new string[arr.Length];
            int i = 0;
            while (i < arr.Length)
            {
                strArr = arr[i].Split(' ');
                
                for (int count = 0; count < strArr.Length; count++)
                {
                    if (strArr[count].Contains("."))
                    {

                        cgpa[i] = strArr[count];
                        i++;
                    }

                }

            }
            string[] unicgpa = cgpa.Distinct().ToArray();//getting unique top three gpa
            var topThree = (from gpa in unicgpa
                            orderby gpa descending
                            select gpa).Take(3);
           
        
            string[] top = topThree.ToArray();
           string[] result = searchGpa(top);
          
            return result;

           


        }


    }
}
