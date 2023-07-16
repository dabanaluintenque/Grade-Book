
/*
    How to run both test and Project in the same command?
        is to create a solution file.
    
    What is a solution file?
        Is a file that keep track multiple projects.

    How to create a solution file?
        in the command line navigate to top level folder
        type { dotnet new sln }

    Now add your project and test into the solution folder.
        Example of this project:
            a) adding the project
            { dotnet sln add src/GradeBook/GradeBook.csproj}
            
            b) adding the test
            { dotnet sln add test/GradeBook.Tests/GradeBook.Tests.csproj}

    How to run solution file?
        run {dotnet build } it will run everything.
        or {dotnet test} it will only run test.


    */