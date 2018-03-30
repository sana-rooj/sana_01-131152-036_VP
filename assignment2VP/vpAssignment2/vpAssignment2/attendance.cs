using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace vpAssignment2
{
    class attendance
    {
        public void markAttendance(string className,string semester)
        {
             int counter = 0;
                 string[] arrVal=dataOperation.dataProperty.read();
                 string[] arr = arrVal.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                 string[] info=new string[arr.Length];// for storing new information with attendance
                int index = 0;//for information storage indexing
                while (index<arr.Length)
                {
                        
                        string[] strArr = arr[index].Split(' ');
                     
                        if (strArr[2] == className.ToLower() && strArr[3]==semester)
                        {
                            string message = strArr[1] + "  " + strArr[0] + "  " + "is present?";
                            string title = "status";
                            MessageBoxButtons button = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show(message, title, button);
                            if (result==DialogResult.Yes)
                            {


                                info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " + "present";
                                index++;
                            }
                            else

                            {
                                // for absent student of the searched class
                                info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " +"absent";
                               
                                index++;
                            }

                   
                        }
                        else
                        {
                            //for student who do not belong to the serached class
                            info[index] = strArr[0] + " " + strArr[1] + " " + strArr[2] + " " + strArr[3] + " " + strArr[4] + " " + "absent";
                            index++;
                            counter++;
                        }


                          
                }
                if (counter == arr.Length)
                    MessageBox.Show("No student to show");
                dataOperation.dataProperty.write(info);
        }
        public string[] viewAttendance(string classNo )
        {
            int counter = 0;
            
            string[] strArr = null;
            string[] arrVal = dataOperation.dataProperty.read();
            string[] arr = arrVal.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            string[] result = new string[arr.Length];
            int i = 0;
            while (i < arr.Length)
            {

                strArr = arr[i].Split(' ');
                if (strArr[3] == classNo)
                {
                    result[i]=strArr[1] + " " + strArr[0] + " " + strArr[5];
                }
                else
                    counter++;
                   i++;
            }
            if (counter == arr.Length)
                MessageBox.Show("No student to show");
            string[] resultVal = result.Where(s => !string.IsNullOrEmpty(s)).ToArray();
            return resultVal;
        }



    }
    }

