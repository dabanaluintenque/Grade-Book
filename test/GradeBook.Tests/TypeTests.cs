namespace GradeBook.Tests;
public delegate string WriteLogDelegate(string logMassage);
public class TypeTests
{
    [Fact]
    public void WriteLogDelegateCanPointToMethod() {
        WriteLogDelegate log;
        log = ReturnMessage;
        var result = log("Hello Dabana");
        Assert.Equal("Hello Dabana" , result);
    }
    private string ReturnMessage(string message){
        return message;
    }
    [Fact]
    public void StringsBehaveLikeValueTypes(){
        string name = "Scott";
        name = MakeUppercase(name);
        Assert.Equal("SCOTT", name);
    }

    private string MakeUppercase(string parameter)
    {
        return parameter.ToUpper();
    }

    [Fact]
    public void Test1(){
        var x = GetInt();
        SetInt(ref x);
        Assert.Equal(77, x);
    }

    private void SetInt(ref int z)
    {
        z = 77;
       
    }

    private int GetInt()
    {
        return 3;
    }

    [Fact]
    public void CSharpCanPassByRef(){
        var book1 = GetBook("Book 1");
        
        GetBookSetName(ref book1, "New Name");
        Assert.Equal("New Name", book1.Name);
    }
    [Fact]
    public void CanSetNameFromReference() 
    {
        // arrange
        var book1 = GetBook("Book 1");
        //GetBookSetName(book1, "New Name");
        // act 

        // assert 
        Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(ref InMemoryBook book, string name)
    {
        book = new InMemoryBook(name);
        //book.Name = name;
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject() {
        var book1 = GetBook("Book 1");
        var book2 = book1;

        Assert.Same(book1, book2);
    }
    InMemoryBook GetBook(string name)
    {
        return new InMemoryBook(name);
    }
}