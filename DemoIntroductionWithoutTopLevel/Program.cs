namespace DemoIntroductionWithoutTopLevel
{
    internal class Program
    {
        int age; // = default(int); 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!" + args);
        }

        void Main2 ()
        {
            int age2;
            Console.WriteLine(this.age);
            //Console.WriteLine(age2);
        }
    }
}
