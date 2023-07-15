
/*
        # Unit Testing
            is automated
            investigate 
            small Units of Code
            Test Runner
            Automation

        Test Library.  xUnit.net
*/

/*
        # How to Create Unit test in C#
            
            #1 Create a test folder separete from your project
            #2 Navigate to your test folder in terminal run the 
                { dotnet new } command to see lest of tamplets we 
                can use to construct a new project
            #3 For this project the framework I want to use is 
                { xUnit Test Project}

            #4 Inside test folder I make another folder called
                { GradeBook.Tests } and then cd into { GradeBook.Tests }

            #5 Now inside { GradeBook.Tests } run the command 
                {dotnet new xunit } it will create project inside 
                {GradeBook.Tests} project

            # Very important note about the xUnit
                xUnit is not a part of the dotnet core as a nuget
                packages that is available for dotnet core
            
            # What is a NuGet ? https://www.nuget.org/
                is a package manager for dotnet and dotnet core

            # How to run a test ?
                Inside your test folder. Ex: GradeBook.Tests 
                run { dotnet test }

            # How to add reference to another project for Test?
                In terminal inside GradeBook.Tests folder run command 
                {dotnet add reference ... } and the path of the project.
                Ex: dotnet add reference ../../src/GradeBook/GradeBook.csproj

            Then add public keyworld to your class modifier.
             
            



*/