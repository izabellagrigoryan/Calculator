namespace Calculator
{
    public class SimpleCalculator
    {
        public float FirstNumber { get; set; }
        public float SecondNumber { get; set; }


        public SimpleCalculator(float firstNumber, float secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }


        public float Summarize()
        { return FirstNumber + SecondNumber; }

        public float Deduct()
        { return FirstNumber - SecondNumber; }

        public float Multiply()
        { return FirstNumber * SecondNumber; }

        public float Divide()
        { return FirstNumber / SecondNumber; }

        public float Percent()
        { return FirstNumber / 100 * SecondNumber; }
    }
}