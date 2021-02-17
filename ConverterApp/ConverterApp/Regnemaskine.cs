namespace ConverterApp
{
    internal class Regnemaskine
    {
        public string Plus(int input1, int input2)
        {
            int result = input1 + input2;

            return result.ToString();
        }

        //har sat denne metode som static. så den er nemmere at bruge end den ovenover! :)
        public static string Minus(int input1, int input2)
        {
            int result = input1 - input2;

            return result.ToString();
        }
    }
}