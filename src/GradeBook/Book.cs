namespace GradeBook {

    public delegate void GradeAddedDelegate( object sender, EventArgs args);
    
    public class InMemoryBook : Book  {

        public InMemoryBook(string name) : base(name) {
            grades = new List<double>();
            Name = name;
        }
       /* public char AddLetterGrade( char letter) 
        {
           switch (letter)
           {
            case 'A':
                AddGrade(90);
                break;
            case 'B':
                AddGrade(80);
                break;
            case 'C':
                AddGrade(70);
                break;
            default:
                AddGrade(0);
                break;
           }
           return letter;
        } */
        public override void AddGrade(double grade) {
            
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                if(GradeAdded != null) {
                    GradeAdded(this, new EventArgs());
                }
            }
            else 
            {
                throw new ArgumentException($"Invalide {nameof(grade)}");      
            }     
        }
        public override event GradeAddedDelegate GradeAdded;

        public override Statistics GetStatistics(){
            var result = new Statistics();

            for (var i = 0; i < grades.Count; i ++ ){
                result.Add(grades[i]);
            }
            return result;
        }
        private List<double> grades;
       
    }
}