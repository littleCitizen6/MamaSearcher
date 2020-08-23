using System;

namespace MamaSearcher
{
    class Program
    {
        public static void writeTheEvent(int index, string pattern)
        {
            Console.WriteLine($"the pattern {pattern} exist at index {index} in the content");
        }
        public static void writeTheEvent2(int index, string pattern)
        {
            Console.WriteLine($"second event writed succesfully for pattern {pattern} he is still exist at index {index} in the content");
        }

        static void Main(string[] args)
        {
            MamaSearch searcher = new MamaSearch();
            searcher.Subscribe("ab", writeTheEvent);
            searcher.Subscribe("a", writeTheEvent);
            searcher.Subscribe("cm", writeTheEvent);
            searcher.Subscribe("ab", writeTheEvent2);
            searcher.PerformSearch("acsdfabcm");
        }
    }
}
