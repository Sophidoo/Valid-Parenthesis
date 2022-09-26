namespace Valid_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(valid("()()"));
        }

        static int valid(string parenthesis)
        {
            
            string parenthesistrimstart = parenthesis.TrimStart(')');
            string parenthesistrimend = parenthesistrimstart.TrimEnd('(');
            int count = 0;
            int count1 = 0;
            int validParenthesis = 0;
            for (int i = 0; i < parenthesistrimend.Length; i++)
            {
                if (parenthesistrimend[i] == '(')
                {
                    count++;
                }
                else if (parenthesistrimend[i] == ')')
                {
                    count1++;
                }

               

            }
            if (count >= count1)
            {
                validParenthesis = count1 * 2;
            }
            else
            {
                validParenthesis = count * 2;
            }
            return validParenthesis;
        }
    }
}