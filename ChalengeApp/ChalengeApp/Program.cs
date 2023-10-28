using Microsoft.Win32.SafeHandles;

internal class Program
{
    private static void Main(string[] args)
    {
        ulong number = 2718281828459045235;
        string numberInString = number.ToString();
        char[] letters = numberInString.ToCharArray();
        int[] cipher = new int[10];

        foreach (char letter in letters)
        {
            cipher[(int)Char.GetNumericValue(letter)] += 1;
        }

        for (int i = 0; i < cipher.Length; i++)
        {
            Console.WriteLine($"{i} => {cipher[i]}");
        }
    }
}