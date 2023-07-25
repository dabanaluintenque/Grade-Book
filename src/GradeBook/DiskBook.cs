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

        public override Statistics GetStatistics(){
            var st = new Statistics();
            
            using (var reader = File.OpenText($"{Name}.txt")) {
                var file_reader = reader.ReadLine();
                while(file_reader != null){
                        var convertyToDouble = double.Parse(file_reader);
                        st.Add(convertyToDouble);
                        file_reader = reader.ReadLine();      
                }   
            }
            return st;
        }
     
    }
}
    
