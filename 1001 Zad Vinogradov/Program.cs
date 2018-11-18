using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001_Zad_Vinogradov
{
    class Program
    {/*Виноградов през 1937 година доказва, че всяко нечетно число, по-голямо от 7, може да се представи като сума на три нечетни прости.
Програмата да изведе комбинациите от 3 прости числа, чиято обща сума е равна на въведеното число.*/
        static void OddNumSumFinder(int odd1, int odd2, int odd3, int num)
        {
          
            
            int sum = odd1 + odd2 + odd3;
            int counter = 1;
        do
        {
            
            while (sum < num)
            {
                odd3 = odd3 + 2;
                sum = odd1 + odd2 + odd3;
            }
            
                if(sum==num)
                {Console.WriteLine("{0}+{1}+{2}", odd1, odd2, odd3);
                sum++;
                }
                else{
                    odd2 = odd2 + 2;
                    odd3 = odd2 + 2;
                    if (odd1 + odd2 + odd3 == num)
                        counter++;
                    sum = odd1 + odd2 + odd3;
            while(sum < num)
            {
                odd3 = odd3 + 2;
                 sum = odd1 + odd2 + odd3;
            }
           
            if (sum == num)
            {
                Console.WriteLine("{0}+{1}+{2}", odd1, odd2, odd3);
                sum++;
            }
            else
            {
                odd1 = odd1 + 2;
                odd2 = odd1 + 2;
                odd3 = odd2 + 2;
                sum = odd1 + odd2 + odd3;
            }
           
            }
               

        } while (counter <= 1);
        }
        static void Main(string[] args)
        {
            int num;
            int oddnum1=1;
            int oddnum2=oddnum1+2;
            int oddnum3=oddnum2+2;
            
            do{Console.WriteLine("Type in the odd number you want to find the sum for(> 7):");
            num =Convert.ToInt32( Console.ReadLine());}
            while(num<7);
            OddNumSumFinder(oddnum1, oddnum2, oddnum3, num);
            Console.ReadLine();

            }
        }
    };


