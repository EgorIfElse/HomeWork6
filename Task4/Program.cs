internal class Program
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string answer = "";
        int chetchik = 0;
        for (int i = 0; str.Length > i; i++)
        {

            if (str[i] == '{')

            {
                chetchik++;
               continue;
            }
            else if (str[i] == '}')

            {
                chetchik--;
                continue;
            }
            if (chetchik == 0)
            {
                answer += str[i];

            }
            
        }
        Console.WriteLine(answer);
    }
}