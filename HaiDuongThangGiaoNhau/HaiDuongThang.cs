using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaiDuongThangGiaoNhau
{
    internal class HaiDuongThang
    {
        public class Parameter
        {
            public float A { get; set; }
            public float B { get; set; }
        }

        public Parameter Input(string DuongThang)
        {
            float a, b;
            Parameter Pr = new Parameter();

            Console.WriteLine($"Hãy nhập tọa đọ đường thẳng [{DuongThang}]");
            //Nhập giá trị cho a
            Console.Write("Nhập giá trị a: ");
            while (!float.TryParse(Console.ReadLine(), out a) || a == 0)
            {
                Console.Write("Mời nhập lại giá trị a:");
            }
            Pr.A = a;

            //Nhập giá trị cho b
            Console.Write("Nhập giá trị b: ");
            while (!float.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Mời nhập lại giá trị b:");
            }
            Pr.B = b;

            Console.WriteLine();
            return Pr;
        }

        public void Equation(string DuongThang,float a, float b)
        {
            Console.WriteLine($"Phương trình đường thẳng [{DuongThang}] Y = {a}X + {b}.\n");
        }
        static void Main(string[] args)
        {
            HaiDuongThang Dt = new HaiDuongThang();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("---Tìm tọa độ giao giữa hai đường thẳng---");
            Console.WriteLine("Phương trình đường thẳng Y = aX + b.\n");

            //Nhập đường thằng
            var line1 = Dt.Input("1");
            var line2 = Dt.Input("1");


            Dt.Equation("1", line1.A, line1.B);
            Dt.Equation("2", line2.A, line2.B);

            //Kiểm tra song song hoặc trùng nhau

            if(line1.A == line2.A)
            {
                if (line1.B == line2.B)
                    Console.WriteLine("Hai đường thẳng trùng nhau (vô số giao điểm).");
                else
                    Console.WriteLine("Hai đường thẳng song song (không có giao điểm).");
            }
            else
            {
                double X = (line2.B - line1.B) / (line1.A - line2.A);
                double Y = line1.A * X + line1.B;
                Console.WriteLine($"Vậy tọa độ giao điểm của đường thẳng [1] và [2] là ({X};{Y})");
            }


            Console.ReadLine();


        }
    }
}
