internal class Program
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strArray = str.Split();
        string max = strArray[0];
        foreach (string a in strArray)
        {


            if (max.Length < a.Length)
            {
                max = a;
            }
        }
        Console.WriteLine(max);
    }
}