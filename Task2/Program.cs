namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое слово или предложение");
            StringHelper sh = new StringHelper(Console.ReadLine());
            Console.WriteLine(sh.ReverseString());

            Console.ReadKey();
        }

        public class StringHelper
        {
            public string stroka { get; }

            public StringHelper(string Stroka)
            {
                stroka = Stroka;
            }


            public string ReverseString() 
            {
                char[] ch = stroka.ToCharArray();
                Array.Reverse(ch);
                return (new string(ch));
            }

        }
    }
}