namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Data Structure problems  *****");
            CustomQUEUE<double> list = new CustomQUEUE<double>();
            list.Enqueue(48.12);
            list.Enqueue(40);
            list.Enqueue(10.2);
            list.Display();
        }
    }
}