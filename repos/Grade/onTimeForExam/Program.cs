using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinetes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinetes = int.Parse(Console.ReadLine());
            string onTime = "On time";
            string earlyTime = "Early";
            string lateTime = "Late";
            string  beforeT = "before the start";
            string  afterT = "after the start";
            string min = "minutes";
            string  hour = "hours";

            int examTime = (examHours * 60) + examMinetes;
            int arrivalTime = (arrivalHours * 60) + arrivalMinetes;
            int deltaT = examTime - arrivalTime;
            int printHH = 0;
            int printMM = 0;

            if (deltaT == 0) // Just On time
            {
                Console.WriteLine(onTime);
            }
            else
            {
                if (deltaT > 0) // (dT>0) If BEFORE start
                {
                    if (deltaT <= 30) // On time MM min before
                    {
                        Console.WriteLine(onTime);
                        Console.WriteLine("{0} {1} {2}", deltaT, min, beforeT);
                    }
                    else // Early Time before
                    {
                        printHH = deltaT / 60;
                        printMM = deltaT % 60;

                        Console.WriteLine(earlyTime);
                        if (printHH == 0)
                        {
                            Console.WriteLine("{0} {1} {2}", printMM, min, beforeT);
                        }
                        else
                        {
                            if (printMM < 10)
                            {
                                Console.WriteLine("{0}:0{1} {2} {3}", printHH, printMM, hour, beforeT);
                            }
                            else
                            {
                                Console.WriteLine("{0}:{1} {2} {3}", printHH, printMM, hour, beforeT);
                            }
                        }

                    }
                }
                else // Late Time after
                {
                    printHH = Math.Abs(deltaT) / 60;
                    printMM = Math.Abs(deltaT) % 60;

                    Console.WriteLine(lateTime);
                    if (printHH == 0)
                    {
                        Console.WriteLine("{0} {1} {2}", printMM, min, afterT);
                    }
                    else
                    {
                        if (printMM < 10)
                        {
                            Console.WriteLine("{0}:0{1} {2} {3}", printHH, printMM, hour, afterT);
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} {2} {3}", printHH, printMM, hour, afterT);
                        }
                    }
                }
            }






        }
    }
}