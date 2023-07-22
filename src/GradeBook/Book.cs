namespace GradeBook {

    public delegate void GradeAddedDelegate( object sender, EventArgs args);

    
    public class Book : NamedOjbect  {


        public Book(string name){
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
        public void AddGrade(double grade) {
            
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
        public event GradeAddedDelegate GradeAdded;
        public Statistics GetStatistics(){
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            
            /*foreach (var grade in grades){
                result.High = Math.Max( grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }
            var index = 0;
            while (index < grades.Count)
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                result.Average += grades[index];
                index ++;
            }*/ 
            for (int i = 0; i < grades.Count; i ++ ){
                result.High = Math.Max(grades[i], result.High);
                result.Low = Math.Min(grades[i], result.Low);
                result.Average +=grades[i];
            }

            result.Average /= grades.Count;
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