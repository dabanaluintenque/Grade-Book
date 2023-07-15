// See https://aka.ms/new-console-template for more information


namespace GradeBook
{
    class Program 
    {
        static void Main(string[] args)
        {
            var book = new Book("Dabana Intenque");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
            Console.WriteLine($"The author name is {book.name}");
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The higest grade is {stats.High}");
            Console.WriteLine($"The lowest grade is {stats.Low}");
    
        }        
    }
}