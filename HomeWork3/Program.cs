namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyArray arr = new MyArray([0, 4, 22, 14, 5, 124, 1, 0, -12, 4, -255]);
            arr.SortDesc();
            arr.show();
            arr.SortAsc();
            arr.show("це");
            //
            Console.WriteLine();
            Console.WriteLine("max: " + arr.Max());
            Console.WriteLine("min: " + arr.Min());
            Console.WriteLine("avg: " + arr.Avg());
            Console.WriteLine("search -3 " + arr.Search(-3));
            Console.WriteLine("search 4 " + arr.Search(4));
            //
            Console.WriteLine();
            arr.SortByParam(false);
            arr.show();
            Console.WriteLine("----------------");
            arr.SortByParam(true);
            arr.show();


        }

    }

}
