namespace GradeBook {

    public delegate void GradeAddedDelegate( object sender, EventArgs args);
    
    public class InMemoryBook : Book  {

        public InMemoryBook(string name) : base(name) {
            grades = new List<double>();
            Name = name;
        }
        public char AddLetterGrade( char letter) 
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
        }
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

            for (int i = 0; i < grades.Count; i ++ ){
                result.Add(grades[i]);
            }
            switch (result.Average)
            {
                case var d when d >= 90: 
                    result.Letter = 'A';
                    break;
                case var d when d >= 80: 
                    result.Letter = 'B';;
                    break;
                case var d when d >= 70: 
                    result.Letter = 'C';;
                    break;
                case var d when d >= 60: 
                    result.Letter = 'D';;
                    break;
                default:
                    result.Letter ='F';
                break;

            }
            return result;
        }
        List<double> grades;
       
    }
}