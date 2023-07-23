namespace GradeBook{

    /* Challenge 
        I want you to write code so that every time this method is invoked, the 
        method will open a file that has the same name as the book and 
        write a new line into the file that contains the grade value.

    */
    public class DiskBook : Book
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrade(double grade)
        { 
           using (var writer = File.AppendText($"{Name}.txt")) {
                writer.WriteLine(grade);
                if (GradeAdded != null) {
                    GradeAdded(this, new EventArgs());
                }
           }
        }

        public override Statistics GetStatistics()
        {
           /*var st = new Statistics();
           st.start = "";
           using (var reader = File.OpenText($"{Name}.txt")) {
            

            while ((st.start = reader.ReadLine()) != null) {

            }

           } 
           return st;*/
           throw new NotImplementedException();
        }
     
    }
}
    
