using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace vpAssignment2
{
    class dataOperation
    {
        private static dataOperation data;
        public static dataOperation dataProperty
        {
            get
            {
                if (data == null)
                    data = new dataOperation();
                return data;
            }

        }
        public string[] read()
        {

            var lines = File.ReadAllLines("file.txt");
            string[] result = new string[lines.Length];
            result = lines;

            return result;
        }
        public void Append(string[] writer)
        {

            System.IO.StreamWriter fileW;
            using (fileW = File.AppendText("file.txt"))
            {
                int size = writer.Length;
                for (int i = 0; i < size; i++)
                {
                    fileW.WriteLine(writer[i]);
                }
            }
            fileW.Dispose();


        }
        public void write(string[] writer)
        {

            System.IO.StreamWriter fileW;
            using (fileW = new StreamWriter("file.txt"))
            {
                int size = writer.Length;
                for (int i = 0; i < size; i++)
                {
                    fileW.WriteLine(writer[i]);
                }
            }
            fileW.Dispose();


        }
        public string[] trimMethod(string[] rewrite)
        {
            int size = rewrite.Length - 1;
            string[] rewriteUpdate = new string[size];
            for (int j = 0; j < size; j++)
            {
                rewriteUpdate[j] = rewrite[j];

            }

            return rewriteUpdate;
        } 

    }
}
