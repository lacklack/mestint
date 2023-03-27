namespace TSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            State state = new State(5, 420);
            Solver nn = new NearestNeightbour(state);
            Console.ReadLine();
        }
    }
}