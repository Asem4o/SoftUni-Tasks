using System;

namespace characterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i <text.Length; i++)
            {
                char letter = text[i];
                Console.WriteLine(letter[i]);
                //1.text.length = дължната на текста
                //2.zeroBasedIndex= определя позициите на символите
                //3.последният символ е на text.length -1 позиция

            }
         
        }
    }
}
