internal class Program
{
    private static void Main(string[] args)
    {
       string str = Console.ReadLine();
        string a =" ";
        int chetchik = 0;

        foreach (char c in str)
        {
            if (c == '{')
            {
                chetchik++;
                continue;
            }



            else if (c == '}')
            {
                chetchik--;
                continue;
            }
               

            if ( chetchik == 0 )
            {
                a += c;
            }

        }

        Console.WriteLine(a);



    }
}