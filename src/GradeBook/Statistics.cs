namespace GradeBook{
    
    public class Statistics 
    {
        public double Average {
            get {
                return Sum /= Count;
            }
        }
        public double High;

        public double Low;

        public char Letter;
        public double Sum;
        public int Count;
        
        public Statistics () {
            //Average;
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