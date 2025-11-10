using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiDuongThangGiaoNhau
{
    internal class HaiDuongThang
    {
        public float A {  get; set; }
        public float B { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        public void Input()
        {
            float a, b;

            //Nhập giá trị cho a
            Console.Write("Nhập giá trị a: ");
            while (!float.TryParse(Console.ReadLine(), out a) || a == 0)
            {
                Console.Write("Mời nhập lại giá trị a:");
            }
            A = a;

            //Nhập giá trị cho b
            Console.Write("Nhập giá trị b: ");
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Mời nhập lại giá trị b:");
            }
            B = b;

            Console.WriteLine();
        }

        public void Equation(string _a,float a, float b)
        {
            Console.WriteLine($"Phương trình đường thẳng [{_a}] Y = {A}X + {B}.\n");
        }
        static void Main(string[] args)
        {
            HaiDuongThang Dt = new HaiDuongThang();
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("---Tìm tọa độ giao giữa hai đường thẳng---");
            Console.WriteLine("Phương trình đường thẳng Y = aX + b.\n");

            //Lưu đường thẳng 1
            Console.WriteLine("Hãy nhập tọa đọ đường thẳng [1]");
            Dt.Input();
            float a1 = Dt.A;
            float b1 = Dt.B;
            //Lưu đường thẳng 2
            Console.WriteLine("Hãy nhập tọa đọ đường thẳng [2]");
            Dt.Input();
            float a2 = Dt.A;
            float b2 = Dt.B;

            Dt.Equation("1", a1, b1);
            Dt.Equation("2", a2, b2);

            double X = (b2 - b1) / (a1 - a2);
            double Y = a1 * X + b1;
            Console.WriteLine($"Vậy tọa độ giao điểm của đường thẳng [1] và [2] là ({X};{Y})");

            Console.ReadLine();


        }
    }
}
