namespace GradeBook.Tests;

/*
        Challenge
            Write a unit test that will prove that the logic inside of Add Grade is working
            inside of the new unit test that you create, instantiate a book and then try to add a grade of 105.
*/
public class BookTests
{
    [Fact]  // fact is attribute 
    public void BookCalculateStatistics()  // fact is attached to this method
    {
        // arrange
        var tst1 = new TypeTests();
        var book = new InMemoryBook("");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        // act
        var result = book.GetStatistics();
    
        // assert 
        Assert.Equal(85.6, result.Average,1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);
        Assert.Equal('B', result.Letter);
        
        
        

    }
}