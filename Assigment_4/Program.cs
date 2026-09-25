using Assigment_4;
using BenchmarkDotNet.Running;
using System;
using System.Globalization;
using System.Text;
using BenchmarkDotNet.Configs;


namespace Assignment4
{
    internal class Program
    {
        static string[] sessionNames =
           {
                "C# Basics",
                "Arrays",
                "Functions",
                "Date and Time",
                "Exception Handling"
            };

        static DateTime[] sessionDates =
            {
                new DateTime(2026, 9, 10, 18, 0, 0),
                new DateTime(2026, 9, 13, 18, 0, 0),
                new DateTime(2026, 9, 17, 18, 0, 0),
                new DateTime(2026, 9, 20, 18, 0, 0),
                new DateTime(2026, 9, 24, 18, 0, 0)
            };

        static int[] sessionDurations =
        {
                180,
                240,
                180,
                240,
                180
         };

        public static void DisplayAllSessions()
        {
            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {sessionNames[i]}");
                Console.WriteLine($"Date : {sessionDates[i].ToString("dd MMMM yyyy")}");
                Console.WriteLine($"Start Time : {sessionDates[i].ToString("hh:mm tt")}");
                Console.WriteLine($"Duration : {sessionDurations[i]} minutes");
                Console.WriteLine();
            }
        }

        public static void SearchSessionName()
        {
            Console.WriteLine("Enter session Name to Search::");
            string sessionName = Console.ReadLine()!;

            var searchIndex = Array.IndexOf(sessionNames,sessionName);

            if (searchIndex == -1)
            {
                Console.WriteLine("Session not found.");
                return;
            }

            Console.WriteLine($"Name: {sessionNames[searchIndex]}");
            Console.WriteLine($"Date : {sessionDates[searchIndex].ToString("dd MMMM yyyy")}");
            Console.WriteLine($"Start Time : {sessionDates[searchIndex].ToString("hh:mm tt")}");
            Console.WriteLine($"Duration : {sessionDurations[searchIndex]} minutes");
            Console.WriteLine();

        }

        public static void SortSessionName()
        {
            string[] copyArray = new string[sessionNames.Length];
            Array.Copy(sessionNames, copyArray, sessionNames.Length);
            copyArray.Sort();
            Console.WriteLine("Sorted copy array:");
            foreach (var item in copyArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        public static void ReverseSessionName()
        {
            string[] copyArray = new string[sessionNames.Length];
            Array.Copy(sessionNames, copyArray, sessionNames.Length);
            Array.Reverse(copyArray);
            Console.WriteLine("Reversed copy array:");
            foreach (var item in copyArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


        }

        public static void FindSessionIndex()
        {
            Console.WriteLine("Enter session Name::");
            string inputStr = Console.ReadLine();
            var index = Array.IndexOf(sessionNames, inputStr);
            if (index == -1)
            {
                Console.WriteLine("item not found");
                return;
            }
            Console.WriteLine($"Index :{index}");
        }

        public static void CheckSessionExist()
        {
            Console.WriteLine("Enter sessionName::");
            string inputName = Console.ReadLine();
            var index = Array.IndexOf(sessionNames, inputName);
            if (index == -1)
            {
                Console.WriteLine("Session does not exist.");
                return;
            }
            Console.WriteLine("Session exists.");
            Console.WriteLine();
        }


        public static void FindSession()
        {
            string input = Console.ReadLine()!;
            //search for string that match condition
            string session = Array.Find(sessionNames, session => session.Contains(input, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(session);


        }

        public static void FindWithIndex()
        {
            Console.Write("Enter session name to search: ");
            string input = Console.ReadLine();

            int index = Array.FindIndex(sessionNames, s => s.Contains(input, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(index != -1 ? $"Found at index: {index}" : "Session not found.");
        }

        public static void CopyArray()
        {
            string[] copyArray = new string[sessionNames.Length];
            Array.Copy(sessionNames, copyArray, sessionNames.Length);
            copyArray[1] = "Mostafa Kamel";
            for (int i = 0; i < sessionNames.Length; i++)
            {
                Console.WriteLine($"original array :{sessionNames[i]} ");
                Console.WriteLine($"copy array:{copyArray[i]}");
                Console.WriteLine();
            }
        }

        public static int TotalDuration()
        {
            int totalDuration = 0;
            for (int i = 0; i < sessionDurations.Length; i++)
            {
                totalDuration += sessionDurations[i];
            }
            return totalDuration;
        }

        public static double AvarageDuration()
        {
            return TotalDuration() / sessionDurations.Length;
        }

        public static int ShortestDuration()
        {
            return sessionDurations.Min();
        }

        public static int LongestDuration()
        {
            return sessionDurations.Max();
        }

        public static void CopySessisionDuration()
        {
            int[] copyArray = new int[sessionDurations.Length];
            Array.Copy(sessionDurations, copyArray, sessionDurations.Length);
            Array.Sort(copyArray);
            Console.WriteLine("Sorted copy Session from smallest to largest");
            foreach (var item in copyArray)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

        }

        public static DateTime GetSessionEndTime(DateTime startDate, int durationMinutes)
        {
            return startDate.AddMinutes(durationMinutes);
        }

        public static void AddRef(ref int a)
        {
            a += 100;

        }

        public static void ReturnTwoValueUsingOut(string name, out int index, out int duration)
        {
            if (sessionNames.IndexOf(name) == -1)
            {
                Console.WriteLine("Session Name not found");
                index = -1;
                duration = 0;
                return;
            }
            index = Array.IndexOf(sessionNames,name);//first out return (index)
            duration = sessionDurations[index];//second out return (duration)
            Console.WriteLine($"index is : {index}");
            Console.WriteLine($"duration is :{duration}");
        }

        public static void RecieveArray(int[] array)
        {
            array[0] = 100;
        }

        public static int CalcuateTotalDuration(params int[] duration)
        {
            int total = 0;
            foreach (var item in duration)
            {
                total += item;
            }
            return total;
        }

        public static void SessionDetails()
        {
            Console.WriteLine("Enter session to search");
            string searchSession = Console.ReadLine() ?? "Enter Valid search";
            int index = Array.IndexOf(sessionNames,searchSession);
            if (index == -1) return;
            Console.WriteLine($"Date: {sessionDates[index]:dd MMMM yyyy}");
            Console.WriteLine($"Day: {sessionDates[index]:dddd}");
            Console.WriteLine($"Year: {sessionDates[index].Year}");
            Console.WriteLine($"Month: {sessionDates[index].Month}");
            Console.WriteLine($"Day Number: {sessionDates[index].Day}");
            Console.WriteLine($"Start Time: {sessionDates[index]:hh:mm tt}");
            Console.WriteLine($"Duration: {sessionDurations[index]} minutes");

            var endTime = sessionDates[index].AddMinutes(sessionDurations[index]);

            Console.WriteLine($"End Time: {endTime:hh:mm tt}");



        }

        public static void DateDifference()
        {
            Console.WriteLine("Enter first session ::");
            string searchSession = Console.ReadLine() ?? "Enter Valid search";

            Console.WriteLine("Enter second session ::");
            string searchSession2 = Console.ReadLine() ?? "Enter Valid search";

            var firstIndex = Array.IndexOf(sessionNames,searchSession);
            var secondIndex = Array.IndexOf(sessionNames,searchSession2);

            if (firstIndex == -1 || secondIndex == -1) { Console.WriteLine("Session not found."); return; }

            TimeSpan timeSpan = sessionDates[secondIndex] - (sessionDates[firstIndex]);
            Console.WriteLine($"{timeSpan.Days} day");
            Console.WriteLine($"{timeSpan.TotalHours} hours");
        }

        public static void PastAndUpComingSessions()
        {
            //foreach(var item in sessionDates)
            for (int i = 0; i < sessionDates.Length; i++)
            {

                if (sessionDates[i] > DateTime.Now)
                {
                    Console.WriteLine($"{sessionNames[i]} UpComing");
                }
                else
                {
                    Console.WriteLine($"{sessionNames[i]} Past");

                }
            }

        }

        public static void FindNextSession()
        {

            int index = Array.FindIndex(sessionDates, item => item > DateTime.Now);

            if (index == -1)
            {
                Console.WriteLine("No upcoming sessions found.");
                return;
            }

            Console.WriteLine("Next session");
            Console.WriteLine(sessionNames[index]);
            Console.WriteLine(sessionDates[index].ToString("dd MMMM yyyy"));
            Console.WriteLine(sessionDates[index].ToString("hh:mm tt"));

            Console.WriteLine("Time remaning");
            var remainingDay = sessionDates[index] - DateTime.Now;
            Console.WriteLine($"{remainingDay.Days} days");
            Console.WriteLine($"{remainingDay.Hours} hours");
            Console.WriteLine();


        }

        public static void DateFormatting()
        {
            var selectedDate = sessionDates[2];
            Console.WriteLine(selectedDate.ToString("dd-MM-yyyy"));
            Console.WriteLine(selectedDate.ToString("dd/MM/yyyy"));
            Console.WriteLine(selectedDate.ToString("dd MMMM yyyy"));
            Console.WriteLine($"{selectedDate.Day} ,{selectedDate.ToString("dd MMMM yyyy")}");
            Console.WriteLine($"{selectedDate.ToString("hh : mm tt")} ");

        }

        private static bool IsDateValid(string date)
        {
            string format = "yyyy-MM-dd HH:mm";
            bool isDate = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime);
            if (isDate)
            {
                return true;
            }
            return false;
        }
        public static void ReadAndValidateTime()
        {
            Console.WriteLine("Enter string DateTime as [yyyy-MM-dd HH:mm] ::");
            string date = Console.ReadLine();

            if (!IsDateValid(date))
            {
                Console.WriteLine("Please Enter valid Date");
                return;
            }
            Console.WriteLine("Date is Valid");

        }


        public static int ExceptionMenuInput()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter menu input:");

                    var input = Console.ReadLine();
                    int parsedInt = int.Parse(input);
                    return parsedInt;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("invalid Numeric option");
                }
            }
        }

        public static void InvalidArrayIndex()
        {
            int index;
            Console.WriteLine("Enter session index");
            index = int.Parse(Console.ReadLine());


            try
            {
                string sessionName = sessionNames[index];
                if (index < sessionNames.Length)
                {
                    Console.WriteLine($"sessions {sessionNames[index]}");
                }

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The selected session index is out of range.");
            }



        }

        public static void ThrowException()
        {
            try
            {
                Console.WriteLine("Enter Duration");
                bool isValidInt = int.TryParse(Console.ReadLine(), out int duration);
                if (isValidInt && duration > 0)
                {
                    Console.WriteLine("duration accepted");
                }
                else
                {
                    throw new ArgumentException("duration");
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Duration must be greater than zero.");
            }
            finally
            {
                Console.WriteLine("Input operation finished.");
            }
        }

        public static string StringConcatenation()
        {
            string result = "";
            for (int i = 0; i < sessionNames.Length; i++)
            {
                result += sessionNames[i] + " - ";
                result += sessionDates[i].ToString("dd/MM/yyyyy hh:mm tt") + " - ";
                result += sessionDurations[i] + " minutes";
                result += "\n";
            }
            return result;

        }

        public static string StringBuilderConcatenation()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sessionNames.Length; i++)
            {
                sb.Append(sessionNames[i] + " - ");
                sb.Append(sessionDates[i].ToString("dd/MM/yyyyy hh:mm tt") + " - ");
                sb.Append(sessionDurations[i] + " minutes");
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static void AcademyAnalyzer()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===================================");
                Console.WriteLine("      Academy Schedule Analyzer");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Display all sessions");
                Console.WriteLine("2. Search for a session");
                Console.WriteLine("3. Sort session names");
                Console.WriteLine("4. Reverse session names");
                Console.WriteLine("5. Find session index");
                Console.WriteLine("6. Check if session exists");
                Console.WriteLine("7. Show duration statistics");
                Console.WriteLine("8. Show session date details");
                Console.WriteLine("9. Show past and upcoming sessions");
                Console.WriteLine("10. Find next session");
                Console.WriteLine("11. Compare two session dates");
                Console.WriteLine("12. Read and validate a custom date");
                Console.WriteLine("13. Select session by index");
                Console.WriteLine("14. Validate session duration");
                Console.WriteLine("15. Generate report using string");
                Console.WriteLine("16. Generate report using StringBuilder");
                Console.WriteLine("0. Exit");
                Console.WriteLine("===================================");

                Console.Write("Choose an option: ");

                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int option))
                {
                    Console.WriteLine("Invalid option. Please enter a number.");
                    Console.ReadKey();
                    continue;
                }

                switch (option)
                {
                    case 1:
                        DisplayAllSessions();
                        break;

                    case 2:
                        SearchSessionName();
                        break;

                    case 3:
                        SortSessionName();
                        break;

                    case 4:
                        ReverseSessionName();
                        break;

                    case 5:
                        FindSessionIndex();
                        break;

                    case 6:
                        CheckSessionExist();
                        break;

                    case 7:
                        Console.WriteLine($"Total Duration    : {TotalDuration()} minutes");
                        Console.WriteLine($"Average Duration  : {AvarageDuration()} minutes");
                        Console.WriteLine($"Shortest Duration : {ShortestDuration()} minutes");
                        Console.WriteLine($"Longest Duration  : {LongestDuration()} minutes");
                        break;

                    case 8:
                        SessionDetails();
                        break;

                    case 9:
                        PastAndUpComingSessions();
                        break;

                    case 10:
                        FindNextSession();
                        break;

                    case 11:
                        DateDifference();
                        break;

                    case 12:
                        ReadAndValidateTime();
                        break;

                    case 13:
                        InvalidArrayIndex();
                        break;

                    case 14:
                        ThrowException();
                        break;

                    case 15:
                        Console.WriteLine("Schedule Report Using string");
                        Console.WriteLine("===================================");
                        Console.WriteLine(StringConcatenation());
                        break;

                    case 16:
                        Console.WriteLine("Schedule Report Using StringBuilder");
                        Console.WriteLine("===================================");
                        Console.WriteLine(StringBuilderConcatenation());
                        break;

                    case 0:
                        Console.WriteLine("Exiting Academy Schedule Analyzer...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose from 0 to 16.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {


            // Part 2 — Display All Sessions
            //DisplayAllSessions();

            // part 3 -Search for session
            //SearchSessionName();

            //part  4.1   Sort Session Names
            //SortSessionName();

            //part 4.2 Reverse Session Names
            //ReverseSessionName();

            //part 4.3 Find Session Index
            //FindSessionIndex();

            //part 4.4 Check if a Session Exists
            //CheckSessionExist();

            //part 4.5 Find a Session
            //FindSession();

            //part 4.6 Find a Session Index Using a Condition
            //FindWithIndex();

            //part 4.7 Copy an Array
            //CopyArray();

            //Part 5 — Duration Analysis
            //Console.WriteLine($"Total Duration is :: {TotalDuration()} minutes");
            //Console.WriteLine($"Average Duration is :: {AvarageDuration()} minutes");
            //Console.WriteLine($"Shortest Duration is : {ShortestDuration()} minutes");
            //Console.WriteLine($"Longest Duration is : {LongestDuration()} minutes");
            //CopySessisionDuration();

            //Part 7 — ref, out, and Reference-Type Parameters

            //-ref
            //int x = 10;
            //Console.WriteLine($"x: {x}");
            //AddRef(ref x);
            //Console.WriteLine($"x: {x}");

            //-out
            //int y = 10;
            //Console.WriteLine("Enter session Name::");
            //string name = Console.ReadLine();
            //ReturnTwoValueUsingOut(name, out int index, out int duration);
            //Console.WriteLine();


            //7.3 Reference Type Without ref
            //int[] arr = [10, 20, 30, 40];
            //Console.WriteLine("Array Before update values");
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            ////BEFORE [10,20,30,40]
            //RecieveArray(arr);
            ////After [100,20,30,40
            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            //the first element is changed because i call reference Type by value 


            //Part 8 — params Keyword
            //Console.WriteLine("Calculate totat duration using Parms::");
            //Console.WriteLine(CalcuateTotalDuration(120, 180));
            //Console.WriteLine(CalcuateTotalDuration(120, 180, 240));
            //Console.WriteLine(CalcuateTotalDuration(120, 180, 60, 80, 40));
            //Console.WriteLine();

            //Part 9 — Session Date Details
            //SessionDetails();

            //Part 10 — Date Difference
            //DateDifference();

            //Part 11 — Past and Upcoming Sessions
            //PastAndUpComingSessions();

            //Part 12 — Find the Next Session
            //FindNextSession();

            //Part 13 — Date Formatting
            //DateFormatting();

            //Part 14 — Read and Validate a Date
            //ReadAndValidateTime();

            //Part 15 — Exception Handling: Menu Input
            //ExceptionMenuInput();

            //Part 16 — Exception Handling: Invalid Array Index
            //InvalidArrayIndex();

            //Part 17 — Throw an Exception && part 18 Add finally
            //ThrowException();

            //Part 19 — Build a Schedule Report Using string
            //Console.WriteLine(StringConcatenation());

            //Part 20 — Build the Same Report Using StringBuilder
            //Console.WriteLine(StringBuilderConcatenation());

            // Benchmark
            //        var config = DefaultConfig.Instance
            //.WithOptions(ConfigOptions.DisableOptimizationsValidator);
            //        BenchmarkRunner.Run<StringBenchmark>(config);



            AcademyAnalyzer();


















        }//end main function 







    }



}