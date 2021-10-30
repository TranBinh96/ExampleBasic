using System;

namespace Example_Basic
{
    class Program
    {
        #region main
        static void Main(string[] args)
        {
            while (true)
            {
                menu();
                Console.WriteLine("Do you want run ? (Y/N)");
                string kt = Console.ReadLine();
                kt = kt.ToLower();
                if (kt == "y")
                {
                    Console.Clear();
                    menu();
                }else
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                
            }
        }
        

        #endregion

        #region menu

        private static void menu()
        {
            Console.WriteLine("Do you choose program ?");
            Console.WriteLine("[1].Excuse_01");
            int choose = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (choose)
            {
                case  1 :
                    Console.WriteLine("You're  choose [1].Excuse_01");
                    Excause_01();
                    break;
                default: Console.WriteLine("Please choose Excuse");
                    break;
            }
        }

        #endregion

        #region Excause

        private static void Excause_01()
        {
            Console.WriteLine("Moi ban nhap tuoi");
            int tuoi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Tuoi ban vua nhap la  : "+tuoi);
            tuoi += 2;
            string tuoi1 = tuoi.ToString();
            Console.WriteLine("Tuoi cua ban la  : "+tuoi1);
            
        }

        #endregion
    } 
}
