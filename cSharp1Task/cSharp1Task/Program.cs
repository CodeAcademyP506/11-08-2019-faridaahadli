using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp1Task
{
    class Program
    {
       static int num = 0;
        static void Main(string[] args)
        {

         
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();
            Console.WriteLine("Xos gelmisiniz: " + name.ToUpper() + ". Telebesiniz? Beli va ya xeyr");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "beli")
            {
                Console.WriteLine("Hansi unide oxuyursunuz?");
                string uni = Console.ReadLine();
                Console.WriteLine("Ixtisasiniz Nedir?");
                string ixtisas = Console.ReadLine();

                Console.WriteLine("1den n-e qeder tek ededlerin cemini hesablamaq ucun.Zehmet olmasa n-i daxil edin");
                int cem = Convert.ToInt32(Console.ReadLine());
                Cem(cem);
                Console.WriteLine("Tesekkur edirik " + name.ToUpper() + ",sen " + uni.ToUpper() + "universitetinde oxuyursan.Ixtisasin " + ixtisas.ToUpper() + "dir ve 1den "+cem+"e qeder tek ededlerin ceminin " + num + " oldugunu bilirsen.");
            }
            else if (answer.ToLower() == "xeyr")
            {
                Console.WriteLine("Isleyirsiniz? Beli ve ya xeyr");
                string workAns = Console.ReadLine();
                if (workAns.ToLower() == "beli")
                {
                    Console.WriteLine("Vezifeniz?");
                    string vezife = Console.ReadLine();
                   Console.WriteLine("1den n-e qeder tek ededlerin cemini hesablamaq ucun.Zehmet olmasa n-i daxil edin");
                    int cem = Convert.ToInt32(Console.ReadLine());
                    Cem(cem);
                    Console.WriteLine("Tesekkur edirik " + name.ToUpper() + ",sen " + vezife.ToUpper() + " vezifesinde isleyirsen ve 1-den "+cem+" e qeder tek ededlerin ceminin " + num + " oldugunu bilirsen.");
                }
                else if (workAns.ToLower() == "xeyr")
                {
                  
                    for (int i = 3; i < 200; i++)
                    {
                        if (i % 3 == 0)
                        {
                            num += i;

                        }

                    }
                    Console.WriteLine("Tesekkur edirik " + name.ToUpper() + ",sen sagirdsen ve buna baxmayaraq 1-den 200-e qeder 3-e bolunen ededlerin ceminin " + num + " oldugunu bilirsen.");
                }
                else
                {
                    Console.WriteLine("Yeniden cehd edin");
                }
            }
            else
            {
                Console.WriteLine("Yeniden cehd edin");
            }
          
        }
        static int Cem(int value)
        {
           
            for (int i = 1; i < value; i++)
            {
                if (i % 2 != 0)
                {
                    num += i;

                }

            }
            return num;
        }

    }
}
