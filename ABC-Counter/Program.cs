using System;

namespace ABC_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello";

            while (word.Length > 0)
            {
                int count = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[0] == word[i])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"{word[0]} = {count}");
                word = word.Replace(word[0].ToString(), "");
            }

        }
    }
}
