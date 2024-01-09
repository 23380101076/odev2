
namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KAÇ SAYI SIRALAMAK İSTERSİN ??");
            int srlm = Int32.Parse(Console.ReadLine());
            if (srlm <= 0)
            {
                Console.WriteLine("SIFIRDAN BÜYÜK VE RAKAMLARLA SIRALAMAK İSTEDİĞİN ADETİ DEKLARE ET");
                return;
            }
            Console.WriteLine("SIRALAMAK İSTEDİĞİNİZ SAYILAR HANGİ ARALIKTA BAŞLASIN ??");
            int strt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("SIRALAMAK İSTEDİĞİNİZ SAYILAR HANGİ ARALIKTA BİTSİN ??");
            int end = Int32.Parse(Console.ReadLine());
            if (strt >= end)
            {
                Console.WriteLine("BAŞLANGIÇ ARALAĞI BİTİŞ ARALIĞINDAN BÜYÜK OLAMAZ.\n LÜTFEN BAŞLANGIÇ SAYISI BİTİŞ SAYISINDAN KÜÇÜK OLACAK ŞEKİLDE GİRİŞ YAPINIZ.");
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
