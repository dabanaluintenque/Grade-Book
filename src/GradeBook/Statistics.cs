namespace GradeBook{
    
    public class Statistics 
    {
        double z = 300.00;
        double c = 3.00;
        public double Average {
            get {
                return  Sum/= Count;
            }
        }
        public double High;

        public double Low;

        public char Letter{
            get {
                if (Sum >= 90){
                    Console.WriteLine(Sum);
                    return 'A';
                }
                else if (Sum >= 80){
                    return 'B';
                }
                else if (Sum >= 70){
                    return 'C';
                }
                else if (Sum >= 60){
                    return 'D';
                }
                else
                {
                    System.Console.WriteLine(z);
                    return 'F';
                }
            }
        } 
        
        public double Sum;
        public int Count;
        
        public Statistics () {
            High = double.MinValue;
            Low = double.MaxValue;
            Sum = 0.0;
            Count = 0;
        }

        public void Add (double number) {
            Sum += number;
            Count += 1;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
            
        }
    }
}