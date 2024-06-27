class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double result = 0;

        for (int i = 1; i <=10; i++) 
        { 
            result = n * i;
            Console.WriteLine($"{n} x {i} = {result}");
            
        }
    }
}