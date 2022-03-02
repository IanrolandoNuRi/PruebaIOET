using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConAppSchedule
{
    class Schedule
    {
        private List<List<string>> Mo, Tu, We, Th, Fr, Sa, Su;
        private List<List<string>> shareHours = new List<List<string>>();

        public void SplitName(string data)
        {
            string[] name = data.Split('=');
            SplitWorkingDays(name[1].Split(','), name[0]);
        }

        public void SplitWorkingDays(string[] workingdays, string name)
        {
            int count = 0;
            foreach (string workingDay in workingdays)
            {
                string day = workingDay.Substring(0, 2);
                int[] hours = new int[2];
                hours = SplitHours(workingDay[2..]);
                for (int i = 0; i < hours[1]; i++)
                {
                    IdentifySchedule(name, day, hours[0]);
                    hours[0] = hours[0] + 1;
                }
                count++;
            }
        }

        public int[] SplitHours(string hours)
        {
            int[] workedHours = new int[2];
            string[] hour = hours.Split('-');
            string[] startHour = hour[0].Split(':');
            string[] finishHour = hour[1].Split(':');
            int firstHour = int.Parse(startHour[0]);
            int secondHour = int.Parse(finishHour[0]);
            if (ValidateTime(int.Parse(startHour[0]), int.Parse(finishHour[0]), int.Parse(startHour[1]), int.Parse(finishHour[1])) == true)  
            {
                if ((firstHour == secondHour) && (int.Parse(finishHour[1]) > int.Parse(startHour[1])))
                    secondHour = secondHour + 1;
                workedHours[0] = firstHour;
                workedHours[1] = secondHour - firstHour;
            }
            return workedHours;
        }

        public bool ValidateTime(int startHour, int finishHour, int startMinutes, int finishhMunutes)
        {
            bool isValid=true;
            if ((startHour < 1) || (startHour > 24)) 
            {
                Console.WriteLine("Error en la primera hora");
                isValid = false;
            }
            if ((finishHour < 1) || (finishHour > 24))
            {
                Console.WriteLine("Error en la segunda hora");
                isValid = false;
            }
            if ((startMinutes < 0) || (startMinutes > 60))
            {
                Console.WriteLine("Error en los primeros minutos");
                isValid = false;
            }
            if ((finishhMunutes < 0) || (finishhMunutes > 60))
            {
                Console.WriteLine("Error en los primeros minutos");
                isValid = false;
            }
            return isValid;
        }

        public void IdentifySchedule(string name, string day, int hours)
        {

            List<string> Data = new List<string>();
            string Hour = hours.ToString() + " : " + (hours + 1).ToString();

            switch (day)
            {
                case "MO":
                    if (Mo == null)
                    {
                        Data = new List<string>();
                        Mo = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        Mo.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Mo.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Mo.Add(Data);
                        }
                    }
                    break;
                case "TU":
                    if (Tu == null)
                    {
                        Data = new List<string>();
                        Tu = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        Tu.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Tu.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Tu.Add(Data);
                        }
                    }
                    break;
                case "WE":
                    if (We == null)
                    {
                        Data = new List<string>();
                        We = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        We.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in We.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            We.Add(Data);
                        }
                    }
                    break;
                case "TH":
                    if (Th == null)
                    {
                        Data = new List<string>();
                        Th = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        Th.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Th.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Th.Add(Data);
                        }
                    }
                    break;
                case "FR":
                    if (Fr == null)
                    {
                        Data = new List<string>();
                        Fr = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        We.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Fr.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Fr.Add(Data);
                        }
                    }
                    break;
                case "SA":
                    if (Sa == null)
                    {
                        Data = new List<string>();
                        Sa = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        Sa.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Sa.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Sa.Add(Data);
                        }
                    }
                    break;
                case "SU":
                    if (Su == null)
                    {
                        Data = new List<string>();
                        Su = new List<List<string>>();
                        Data.Add(Hour);
                        Data.Add(name);
                        Su.Add(Data);
                    }
                    else
                    {
                        bool find = false;
                        foreach (var rows in Su.ToList())
                        {

                            Data = new List<string>();
                            if (Hour == rows.First())
                            {
                                rows.Add(name);
                                find = true;
                            }
                        }
                        if (find == false)
                        {
                            Data.Add(Hour);
                            Data.Add(name);
                            Su.Add(Data);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Error: Dia no encontrado");
                    break;
            }
        }

        public void ShowSchedule()
        {
            Console.WriteLine("Calendario Dias Trabajados\n");
            if (Mo != null)
            {
                Console.WriteLine("Lunes");
                ShowDay(Mo);
            }

            if (Tu != null)
            {
                Console.WriteLine("Martes");
                ShowDay(Tu);
            }

            if (We != null)
            {
                Console.WriteLine("Miercoles");
                ShowDay(We);
            }
            if (Th != null)
            {
                Console.WriteLine("Jueves");
                ShowDay(Th);
            }

            if (Fr != null)
            {
                Console.WriteLine("Viernes");
                ShowDay(Fr);
            }
            if (Sa != null)
            {
                Console.WriteLine("Sabado");
                ShowDay(Sa);
            }
            if (Su != null)
            {
                Console.WriteLine("Domingo");
                ShowDay(Su);
            }
            Console.WriteLine();
        }

        public void ShowDay(List<List<string>> day)
        {
            foreach (var rows in day)
            {
                foreach (var columns in rows)
                {
                    Console.Write(columns + " ");
                }
                Console.WriteLine();
            }
        }

        public void ShowShareHours()
        {
            insertShareHours();
            ShareHours();
        }

        public void insertShareHours()
        {
            if (Mo != null)
            {
                foreach (List<string> rows in Mo)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (Tu != null)
            {
                foreach (List<string> rows in Tu)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (We != null)
            {
                foreach (List<string> rows in We)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (Th != null)
            {
                foreach (List<string> rows in Th)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (Fr != null)
            {
                foreach (List<string> rows in Fr)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (Sa != null)
            {
                foreach (List<string> rows in Sa)
                {
                    ValidateSizeRows(rows);
                }
            }
            if (Su != null)
            {
                foreach (List<string> rows in Su)
                {
                    ValidateSizeRows(rows);
                }
            }
        }

        public void ShareHours()
        {
            Console.WriteLine("Horario coincidente");

            foreach (List<string> rows in shareHours)
            {
                Console.WriteLine(rows[0] + "-" + rows[1] + ": " + rows[2]);
            }
        }


        public void ValidateSizeRows(List<string> rows)
        {
            int count = 1;
            if (rows.Count > 2)
            {
                while (count < rows.Count - 1)
                {
                    ShareHour(rows[count], rows[count + 1]);
                    count++;
                }
            }
        }    

        public void ShareHour(string firstPerson, string secondPerson)
        {
            if (shareHours != null)
            {
                bool existHours = ExistInShareHours(firstPerson, secondPerson);
                if (existHours != true)
                {
                    AddRowHour(firstPerson, secondPerson);
                }
            }
            else
            {
                AddRowHour(firstPerson, secondPerson);
            }
        }

        public void AddRowHour(string firstPerson, string secondPerson)
        {
            List<string> addRow = new List<string>();
            addRow.Add(firstPerson);
            addRow.Add(secondPerson);
            addRow.Add("1");
            shareHours.Add(addRow);
        }

        public bool ExistInShareHours(string firstPerson, string secondPerson)
        {
            foreach (List<string> rows in shareHours)
            {
                bool findFirst = false;
                bool findSecond = false;
                if (rows[0] == firstPerson || rows[1] == secondPerson)                
                    findFirst = true;
                if (rows[0] == secondPerson || rows[1] == secondPerson)                
                    findSecond = true;                
                if ((findFirst == true) && (findSecond == true))
                {
                    rows[2] = (int.Parse(rows[2]) + 1).ToString();
                    return true;
                }                
                
            }
            return false;           
        }      
    }

}
