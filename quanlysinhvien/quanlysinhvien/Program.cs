using System;
using System.Collections.Generic;
using System.Text;

namespace quanlysinhvien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.UTF8;
            listSV ls = new listSV();
            sinhvien sv = new sinhvien();
            List<sinhvien> sinhvien = new List<sinhvien>();
            int t = 0;
            do
            {
                Console.WriteLine("=========_____==========");
                Console.WriteLine("1.Thêm học sinh mới");
                Console.WriteLine("2.Hiển thị DS:");
                Console.WriteLine("3.Liệt kê dtb lơn hơn bằng 8: ");
                Console.WriteLine("4.sap xep theo ma sinh vien :");
                t = int.Parse(Console.ReadLine());
                switch (t)
                {
                    case 1:
                        {
                            sinhvien = ls.AddSV();
                            break;
                        }
                    case 2:
                        {
                            ls.displaySV();
                            break;
                        }
                    case 3:
                        {
                            ls.lietkeSV();
                            break;
                        }
                    case 4:
                        {
                            ls.arrgeID();
                            break;
                        }
                }
            } while (t != 4);
            Console.ReadKey();
        }
       
    }
}
