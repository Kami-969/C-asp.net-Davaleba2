using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Davaleba
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sheiyvanet A = : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sheiyvanet B = : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sheiyvanet C = : ");
            int c = Convert.ToInt32(Console.ReadLine());

            discriminant(a, b, c);


            Console.ReadKey();
        }

        static void discriminant(int a , int b, int c)
        {
            double square_side = Convert.ToInt64(Math.Pow(b, 2) -4 * -a * -c);
            double srulifesvi = Math.Sqrt(square_side) % 1;
            if (square_side > 0)
            {
                if(srulifesvi == 0)
                { 
                
                double x1 = (-b / (a * 2) + (Math.Sqrt(square_side) / (a * 2)));
                double x2 = (-b / (a * 2) - (Math.Sqrt(square_side) / (a * 2)));

                Console.WriteLine("\n\nam gantolebas gaachnia 2 amonaxsni\n");
                Console.WriteLine($"X1 = {x1} \nX2 = {x2}");
                }
                else
                {
                    // აქ გავიჭედე ანუ სრული ფესვი თუ ამოდის ამოხსნას ახერხებს ეს მეთოდი მაგრამ თუ სრულად არ ამოდის ბანძი რიცხვები გამოაქვს პასუხისგან მოშერებული
                    // ანუ ვიდეოს მიხედვით წილადად უნდა დარჩეს და მაქამდე როგორ მივიდე ვეღარ ვხვდები უკვე. ერთი რაც ვიფიქრე ფესვის ამოყვანის ფუნქცია რომ ჩემით დავწერო
                    // და იქიდან გავუწიო კონტროლი სადამდე დავიდეს ფესვში მამრავლებამდე რომ შემდეგ გავაგრძელო ალბათ.
                }
            }
            else if(square_side == 0 )
            {
                double x1 = (-b / (a * 2) + (Math.Sqrt(square_side) / (a * 2)));
                double x2 = (-b / (a * 2) - (Math.Sqrt(square_side) / (a * 2)));

                Console.WriteLine("\nam gantolebas gaachnia 1 gameorebuli amonaxsni\n");
                Console.WriteLine($"X1 = {x1} \nX2 = {x2}");
            }
            else
            {
                throw new Exception("am gantolebas amonaxsni ar gaachnia");
                
            }
        }
    }
}
