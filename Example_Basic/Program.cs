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
            Console.WriteLine("[2].Can Bac Hai");
            Console.WriteLine("[3].Tinh Tong");
            Console.WriteLine("[4].Bang Cuu Chuong");
            int choose = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (choose)
            {
                case  1 :
                    Console.WriteLine("You're  choose [1].Excuse_01");
                    Excause_01();
                    break; 
                case  2 :
                    Console.WriteLine("You're  choose [2].Excuse_02");
                    Excause_02();
                    break;
                case 3:
                    Console.WriteLine("You're  choose [3].Tinh Tong");
                    Excause_03();
                    break; 
                case 4:
                    Console.WriteLine("You're  choose [4].Bang Cuu Chuong:");
                    Excause_04();
                    break;
                default: Console.WriteLine("Please choose Excuse");
                    break;
            }
        }

        private static void Excause_04()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.Write("\n");
            Console.Write("In bang cuu chuong 2 - 9:\n");
            Console.Write("----------------------------");
            Console.Write("\n\n");

            int num, so_nhan;

            num = 2;

            do
            {

                so_nhan = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",
                        num, so_nhan, num * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 10);

                Console.WriteLine();
                num++;

            } while (num <= 9);   
        }

        private static void Excause_03()
        {
           Console.WriteLine("Moi Ban Nhap Gia Tri  : ");
           int n = Int32.Parse(Console.ReadLine());
           double kq = 0;
           for (int i = 0; i < n; i++)
           {
               kq += i;
           }
           Console.WriteLine("Tong Gia Tri : "+kq);
           

           
        }

        private static void Excause_02()
        {
           Console.WriteLine("Moi ban nhap A : ");
           int a =Int32.Parse(Console.ReadLine());
           Console.WriteLine("Moi ban nhap B : ");
           int b =Int32.Parse(Console.ReadLine());
           Console.WriteLine("Moi ban nhap C : ");
           int c =Int32.Parse(Console.ReadLine());
           Console.Clear();
           Console.WriteLine(a+"X2 +" +b+"X +" +c+"C");

           float dealta = b * b - 4 * a * c;
           if (dealta < 0)
           {
               Console.WriteLine("Phuong Trinh vô nghiệp");
           }
           else if (dealta == 0)
           {
               double x =  -b  / (2 * a);
               Console.WriteLine("Phuong trinh co nghiep kep : x1=x2 = "+x);
           }
           else
           {
               double x1 = ( -b + Math.Sqrt(dealta) )/ (2 * a);
               double x2 = ( -b - Math.Sqrt(dealta) )/ (2 * a);
               Console.WriteLine("Phuong trinh co 2 nghiep phan biet : ");
               Console.WriteLine("X1 = "+x1);
               Console.WriteLine("X1 = "+x2);
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
