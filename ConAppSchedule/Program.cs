using System;
using System.IO;

namespace ConAppSchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenFile();
        }

        static void OpenFile()
        {
            Schedule schedule = new Schedule();
            string FileToRead = @"..\..\..\input.txt";
            using (StreamReader ReaderObject = new StreamReader(FileToRead))
            {
                string Line;
                // ReaderObject reads a single line
                while ((Line = ReaderObject.ReadLine()) != null)
                {
                    schedule.SplitName(Line);
                }
            }
            schedule.ShowSchedule();
            schedule.ShowShareHours();
        }
    }
}
