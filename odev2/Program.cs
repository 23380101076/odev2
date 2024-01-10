
namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO, WELCOME TO THE RANDOM NUMBER SORTING APPLICATION.\n OUR APPLICATION WILL ASK YOU 3 QUESTIONS AND EXPECT YOU TO ENTER THEM EXCLUSIVELY IN DIGITS.\n REMEMBER, THE NUMBER YOU WANT TO SORT SHOULD BE GREATER THAN 0. THE STARTING NUMBER SHOULD NOT BE GREATER THAN OR EQUAL TO THE ENDING NUMBER.\n THE RANGE YOU WANT TO SORT MUST BE COMPATIBLE WITH THE NUMBER OF ELEMENTS YOU WANT TO SORT.\n NOW, WE WILL ASK YOU HOW MANY NUMBERS YOU WANT TO SORT.");
            Console.WriteLine("HOW MANY NUMBERS DO YOU WANT TO SORT??");
            int srlm = Int32.Parse(Console.ReadLine());
            if (srlm <= 0)
            {
                Console.WriteLine("DECLARE THE NUMBER OF ELEMENTS TO SORT, WHICH SHOULD BE GREATER THAN ZERO AND CONSIST OF DIGITS");
                return;
            }
            Console.WriteLine("IN WHAT RANGE DO YOU WANT THE NUMBERS TO START ??");
            int strt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("IN WHAT RANGE DO YOU WANT THE NUMBERS TO END ??");
            int end = Int32.Parse(Console.ReadLine());
            if (strt >= end)
            {
                Console.WriteLine("THE STARTING RANGE CANNOT BE GREATER THAN THE ENDING RANGE.\nPLEASE ENTER THE STARTING NUMBER TO BE LESS THAN THE ENDING NUMBER.");
                return;
            }
            Random random = new Random();
            int[] worktwo = new int [srlm];
            for (int i = 0; i < srlm;)
            {
                int work = random.Next(strt, end + 1); 
                int j;

                for (j = 0; j < i; j++)
                {
                    if (worktwo[j] == work)
                    {
                        break; 
                    }
                }
                if (j == i) 
                {
                    worktwo[i] = work;
                    i++; 
                }
            }
            Array.Sort(worktwo);
            for (int i = 0; i < srlm; i++)
            {
                Console.WriteLine(worktwo[i]);
            }
        }
    }
}
