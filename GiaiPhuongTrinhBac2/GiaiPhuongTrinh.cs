using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBac2
{
    internal class GiaiPhuongTrinh
    {
        public class Parameter
        {
            public int A { get; set; }
            public int B { get; set; }
            public int C { get; set; }
        }

        public void Input()
        {
            int a,b,c;
            Parameter Pr = new Parameter();
            //Nhập giá trị cho a
            Console.Write("Nhập giá trị a: ");
            while(!int.TryParse(Console.ReadLine(),out a))
            {
                Console.Write("Mời nhập lại giá trị a:");
            }
            Pr.A = a;

            //Nhập giá trị cho b
            Console.Write("Nhập giá trị b: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Mời nhập lại giá trị b:");
            }
            Pr.B = b;

            //Nhập giá trị cho c
            Console.Write("Nhập giá trị c: ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Mời nhập lại giá trị c:");
            }
            Pr.C = c;

            Console.WriteLine();
        }

        public float Denta()
        {
            Parameter Pr = new Parameter();

            return (float)Math.Pow(Pr.B, 2) - 4*Pr.A *Pr.C;
        }

        public void Solve()
        {
            float _Denta = Denta();
            Parameter Pr = new Parameter();

            if (Pr.A == 0)
            {
                //Trường hợp phương trình bậc nhất
                if(Pr.B == 0)
                {
                    if (Pr.C == 0) 
                        Console.WriteLine("-> Phương trình vô số nghiệm");
                    else 
                        Console.WriteLine("-> Phương trình vô nghiệm");
                }
                else
                {
                    float x = -(float)(Pr.C / Pr.B);
                    Console.Write($"-> Phương trình {Pr.B}x = {Pr.C} có nghiệm duy nhất: {x}");
                }
            }
            else
            {
                if (_Denta < 0)
                    Console.WriteLine($"-> Phương trình {Pr.A}x² + {Pr.B}x + {Pr.C} = 0 vô số nghiệm");
                else if (_Denta == 0)
                    Console.WriteLine($"-> Phương trình {Pr.A}x² + {Pr.B}x + {Pr.C} = 0 có nghiệm kép: x = {-Pr.B / (2f * Pr.A)}");
                else
                {
                    double sqrtD = Math.Sqrt(_Denta);
                    double x1 = (-Pr.B + sqrtD) / (2f * Pr.A);
                    double x2 = (-Pr.B - sqrtD) / (2f * Pr.A);
                    Console.WriteLine($"->Phương trình {Pr.A}x² + {Pr.B}x + {Pr.C} = 0 có hai nghiệm phân biệt.");
                    Console.WriteLine($" X1 = {x1}\n X2 = {x2}");
                }
            }

        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---Giải phương trình bậc 2---\n Dạng tổng quát: ax² + bx + c = 0\n");

            GiaiPhuongTrinh Pt = new GiaiPhuongTrinh();
            Pt.Input();
            Pt.Solve();
        }
    }
}
