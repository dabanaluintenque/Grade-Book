namespace GradeBook.Tests;

/* Write a assert that somethng is == book1 
and book2  */
public class TypeTests
{
    public void Test1() 
    {
        // arrange
        var book1 = GetBook("Book 1");
        var book2 = GetBook("Book 2");
        // act 

        // assert 
        Assert.Equal("Book 1", book1.Name);
        Assert.Equal("Book 2", book2.Name);
    }

    Book GetBook(string name)
    {
        return new Book(name);
    }
}