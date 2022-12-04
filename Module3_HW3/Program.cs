namespace Module3_HW3
{
    public delegate int PowHandler(int a, int b);
    public delegate bool ResultHandler(int number);

    public class Program
    {
        public static void Show(bool result)
        {
            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            Class1.Show showDelegate = Program.Show;
            ResultHandler resultHandler = Class2.Calc(Class1.Pow, 3, 9);
            showDelegate(resultHandler(3));
        }
    }
}