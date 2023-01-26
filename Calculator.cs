namespace Math
{
    public class Calculator
    {
        private float FirstValue { get; set; }
        private float SecondValue { get; set; }

        public Calculator(float firstValue, float secondValue) {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public float Addition(float firstValue, float secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            return firstValue + secondValue;
        }
        public float Multiplication(float firstValue, float secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            return firstValue * secondValue;
        }
        public float Subtraction(float firstValue, float secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            return FirstValue - secondValue;
        }
        public float Divide(float firstValue, float secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
            return FirstValue / secondValue;
        }

    }
}