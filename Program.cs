namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // Add Task 1 to Task 6 here, in this order.
           
           // ---- Task 1 ----
            int points = 10;                 // TODO 1: start with 10 points
            points += 5;                    // TODO 2: add 5 using +=, then double using *=
            points *= 2;                    
            // TODO 3: compare final points with 25 using >= and print the bool
            Console.WriteLine($"Final points: {points}");   
            
            bool atLeast25 = points >= 25;
            Console.WriteLine($"At least 25 points: {atLeast25}");

            // TODO 4: use points++ and ++points in two separate expressions
            int afterPost = points++;        // returns 30, then stores 31
            Console.WriteLine($"points++ returned {afterPost}; points is now {points}");

            int afterPre = ++points;         // stores 32, then returns 32
            Console.WriteLine($"++points returned {afterPre}; points is now {points}");
            
            // ---- Task 2 ----
            int marks = 72;                  // TODO 1: change these two values to test
            int attendance = 80;

            // TODO 2: grade A for 80+, B for 65–79, C for 50–64, otherwise Fail
            string grade = "";
            if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 65)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }


            // TODO 3: eligible when marks >= 50 AND attendance >= 75
            bool isEligible = false;
            isEligible = marks >= 50 && attendance >= 75;

            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");

            // ---- Task 3 ----
            int choice = 2;                  // TODO 1: test with 1, 3 and 9
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            // TODO 2: switch on choice with cases 1, 2, 3 and a default
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Borrow. ");
                    break;
                case 2:
                    Console.WriteLine("You selected Return. ");
                    break;
                case 3:
                    Console.WriteLine("You selected Renew. ");
                    break;
                default:
                    Console.WriteLine("Invalid choice. ");
                    break;


            }

            string? userName = null; 
            string displayName = userName ?? "Guest";
            Console.WriteLine($"Display name: {displayName}");        // TODO 3: ?? displays "Guest"
            // TODO 4: ??= assigns "Guest" only when userName is null
            userName ??= "Guest";
            Console.WriteLine($"userName after ??=: {userName}");

            // ---- Task 4 ----
            int[] dailyAttendance = { 20, 22, 21, 24, 23 }; // TODO 1: Monday to Friday
            int total = 0;

            // TODO 2: foreach — print each value and add it to total
            Console.WriteLine("Daily attendance:");
            foreach (int present in dailyAttendance)
            {
                Console.WriteLine($"  {present}");
                total += present;
            }
            Console.WriteLine($"Total attendance: {total}");
            // TODO 3: for — print "Day 1: 20" through "Day 5: 23"
            for (int i = 0; i < dailyAttendance.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyAttendance[i]}");
            }
            // TODO 4: while — count down from 3 to 1
            int countdown = 3;
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
            }
            // TODO 5: do-while — print "Attendance recorded" once with runAgain = false
            bool runAgain = false;
            do
            {
                Console.WriteLine("Attendance recorded");
            }
            while (runAgain);  

            // ---- Task 5 ----
            // TODO 1: nested for loops printing "Row 1 - Seat 1" to "Row 3 - Seat 4" 
            // TODO 1: count and print the total number of seats
            int seatCount = 0;

            for (int row = 1; row <= 3; row++)
            {
                for (int seat = 1; seat <= 4; seat++)
                {
                    Console.WriteLine($"Row {row} - Seat {seat}");
                    seatCount++;
                }
            }
            Console.WriteLine($"Total seats: {seatCount}");
            
            // TODO 2: for 1 to 10, continue at 5 and break at 8
            Console.Write("Loop values: ");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;                // skip printing 5
                }
                if (i == 8)
                {
                    break;                   // leave the loop before printing 8
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            
            // ---- Task 6 ----
            // TODO 1: ask for two integers with Console.ReadLine()
            Console.Write("Enter the first integer: ");
string firstInput = Console.ReadLine() ?? "";
Console.Write("Enter the second integer: ");
string secondInput = Console.ReadLine() ?? "";
            
            // TODO 2: inside try, int.Parse both inputs and divide first by second
            try
            {
                int first = int.Parse(firstInput);
                int second = int.Parse(secondInput);
                int result = first / second;
                Console.WriteLine($"Result: {result}");
            }
            // TODO 3: catch FormatException and DivideByZeroException separately
            catch (FormatException)
            {
                Console.WriteLine("Error: please enter whole numbers only.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: cannot divide by zero.");
            }
            // TODO 4: finally prints "Calculation complete"
            finally
            {
                Console.WriteLine("Calculation complete");
            }
 

        }
    }
}
