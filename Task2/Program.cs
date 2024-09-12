internal class Program
{
    private static void Main(string[] args)
    {
        string str1 = Console.ReadLine();

        string str3 = "";
        string str2 = "";
        foreach (char c in str1)

        {
            str2 = c + str2;
          
            str2 = str2.ToLower().Trim();
        }
        foreach (char b in str1)

        {
            str3 += b;

            str3 = str3.ToLower().Trim();
        }

                
        if (str2 == str3)
        {
            Console.WriteLine("Полиндром");
        }
        else
        {
            Console.WriteLine(str2);

        }
    }
}