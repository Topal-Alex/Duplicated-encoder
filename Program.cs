using System;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string word = Console.ReadLine();
            word = word.ToLower();
            string newline = "";
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 1; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        newline = newline.Insert(i,")");
                        break;
                        
                    }
                    else
                    {
                        newline = newline.Insert(i, "(");
                        break;
                    }
                    
                }
            }

            Console.WriteLine(newline);
            



        }

        
        
        
       
    }
}