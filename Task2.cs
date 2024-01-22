namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the string: ");
                string ss = Console.ReadLine();
                string statment = IsPalindrome(ss.ToLower()) ? $"{ss} is a Palindrome" : $"{ss} is not a Palindrome";
                Console.WriteLine(statment);
            }
        }
        static bool IsPalindrome(string s)
        {
            int i = 0, j = s.Length - 1;
            while (i != j && i < j)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
/*
Enter the string: MMMM
MMMM is a Palindrome
Enter the string: Dad
Dad is a Palindrome
Enter the string: Hussein
Hussein is not a Palindrome
*/
