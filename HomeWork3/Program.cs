namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public interface IOutput
    {
        void show();
        void show(string info);

    }
    public class MyArray : IOutput
    {
        public void show()
        {

        }

        public void show(string info)
        {

        }
    }
}
