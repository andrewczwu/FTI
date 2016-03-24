using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsFromInteger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter an integer less than 1 billion");
            int number = Int32.Parse(Console.ReadLine());
            string answer = new IntegerWords().WordsFromInteger(number);
            Console.WriteLine(answer);
            Console.WriteLine("press enter to exit");
            Console.ReadLine();
        }

    }

    public class IntegerWords
    {
        private readonly Dictionary<int, string> teensMapping = new Dictionary<int, string>();
        private readonly Dictionary<int, string> onesMapping = new Dictionary<int, string>();
        private readonly Dictionary<int, string> tensMapping = new Dictionary<int, string>();

        private readonly string[] expoMapping = new string [] { "", "thousand", "million" };
        public IntegerWords()
        {
            teensMapping.Add(10, "ten"); teensMapping.Add(11, "eleven"); teensMapping.Add(12, "twelve");
            teensMapping.Add(13, "thirteen"); teensMapping.Add(14, "fourteen"); teensMapping.Add(15, "fifteen");
            teensMapping.Add(16, "sixteen"); teensMapping.Add(17, "seventeen"); teensMapping.Add(18, "eighteen");
            teensMapping.Add(19, "nineteen");

            onesMapping.Add(0, ""); onesMapping.Add(1, "one"); onesMapping.Add(2, "two"); onesMapping.Add(3, "three"); onesMapping.Add(4, "four");
            onesMapping.Add(5, "five"); onesMapping.Add(6, "six"); onesMapping.Add(7, "seven"); onesMapping.Add(8, "eight");
            onesMapping.Add(9, "nine");

            tensMapping.Add(2, "twenty"); tensMapping.Add(3, "thirty"); tensMapping.Add(4, "fourty"); tensMapping.Add(5, "fifty");
            tensMapping.Add(6, "sixty"); tensMapping.Add(7, "seventy"); tensMapping.Add(8, "eighty"); tensMapping.Add(9, "ninety");
        }

        public string WordsFromInteger(int i)
        {
            if (i > 999999999) return "Error too large";
            string returnWords = "";
            string currentInterationWords = "";
            if (i == 0) return "zero";
            int expoIndex = 0;

            int currentIteration = i;
            while (currentIteration > 0)
            {
                int extractThousand = currentIteration % 1000;

                if (extractThousand > 0)
                {
                    int extractHundreds = currentIteration % 100;
                    int extracttens = currentIteration % 10;

                    string tensWord = onesMapping[extracttens];
                    string hundredsWord = "";

                    if (extractHundreds >= 10 && extractHundreds < 20)
                    {
                        tensWord = teensMapping[extractHundreds];
                    }
                    else if (extractHundreds > 19)
                    {
                        tensWord = tensMapping[extractHundreds / 10];
                        if (extracttens > 0)
                        {
                            tensWord += " " + onesMapping[extracttens];
                        }
                    }

                    if (extractThousand >= 100)
                    {
                        hundredsWord = onesMapping[extractThousand / 100] + " hundred";
                        currentInterationWords = hundredsWord + " " + tensWord;
                    }
                    else
                    {
                        currentInterationWords = tensWord;
                    }

                    string expoWord = expoMapping[expoIndex];
                    if (expoIndex != 0) currentInterationWords = currentInterationWords + " " + expoWord;
                    returnWords = currentInterationWords + " " + returnWords;
                }
                currentIteration = currentIteration / 1000;
                expoIndex++;
            }
            return returnWords.TrimEnd();
        }
    }
}
