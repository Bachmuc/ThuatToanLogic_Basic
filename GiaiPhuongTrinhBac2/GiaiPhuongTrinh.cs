using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaiPhuongTrinhBac2
{
    internal class GiaiPhuongTrinh
    {
        public int A {  get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public void Input()
        {
            int a,b,c;

            //Nhập giá trị cho a
            Console.Write("Nhập giá trị a: ");
            while(!int.TryParse(Console.ReadLine(),out a))
            {
                Console.Write("Mời nhập lại giá trị a:");
            }
            A = a;

            //Nhập giá trị cho b
            Console.Write("Nhập giá trị b: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Mời nhập lại giá trị b:");
            }
            B = b;

            //Nhập giá trị cho c
            Console.Write("Nhập giá trị c: ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Mời nhập lại giá trị c:");
            }
            C = c;

            Console.WriteLine();
        }

        public float Denta()
        {
            return (float)Math.Pow(B, 2) - 4*A*C;
        }

        public void Solve()
        {
            float _Denta = Denta();

            if(A == 0)
            {
                //Trường hợp phương trình bậc nhất
                if(B == 0)
                {
                    if (C == 0) 
                        Console.WriteLine("-> Phương trình vô số nghiệm");
                    else 
                        Console.WriteLine("-> Phương trình vô nghiệm");
                }
                else
                {
                    float x = -(float)(C / B);
                    Console.Write($"-> Phương trình {B}x = {C} có nghiệm duy nhất: {x}");
                }
            }
            else
            {
                if (_Denta < 0)
                    Console.WriteLine($"-> Phương trình {A}x² + {B}x + {C} = 0 vô số nghiệm");
                else if (_Denta == 0)
                    Console.WriteLine($"-> Phương trình {A}x² + {B}x + {C} = 0 có nghiệm kép: x = {-B / (2f * A)}");
                else
                {
                    double sqrtD = Math.Sqrt(_Denta);
                    double x1 = (-B + sqrtD) / (2f * A);
                    double x2 = (-B - sqrtD) / (2f * A);
                    Console.WriteLine($"->Phương trình {A}x² + {B}x + {C} = 0 có hai nghiệm phân biệt.");
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
