// See https://aka.ms/new-console-template for more information

/* TASK
 Make changes to this program so that instead of hard-coding these grades
 into the program you are taking the grades from the console and you'are
 typing the grades into the program at run-time

 # Conditions and expectation:
    So, when I run this program, I want the program to prompt me and 
    say, please enter a grade if I enter a number, like 72, that number
    is added to the book, and I want you to set up a loop so that I can
    enter as many numbers as I want. Only if I enter the letter Q will
    you stop accepting grades and you'll go ahead and compute statistics
    and then show those statistiscs on the console.
*/
namespace GradeBook
{
    class Program 
    {
        static void Main(string[] args)
        {
            var book = new Book("Dabana Intenque");
           /*book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);*/
            while (true) {
                Console.WriteLine("Enter The list of Grades");
                var input = Console.ReadLine();
                if( input == "Q"){
                    Console.WriteLine("I am out");
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            var stats = book.GetStatistics();
            Console.WriteLine($"The author name is {book.Name}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The higest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }        
    }
} 