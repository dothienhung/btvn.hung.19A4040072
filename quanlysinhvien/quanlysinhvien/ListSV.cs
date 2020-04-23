using System;
using System.Collections.Generic;
using System.Text;

namespace quanlysinhvien
{
    class listSV
    {
        List<sinhvien> ListSV = new List<sinhvien>();
        public List<sinhvien> AddSV()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhap ID:");
            int ID = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten:");
            string HoTen = Console.ReadLine();
            Console.WriteLine("Nam sinh la :");
            int Ns = int.Parse(Console.ReadLine());
            Console.WriteLine("diem lap trinh là :");
            double dlt = double.Parse(Console.ReadLine());
            Console.WriteLine("diem co so du lieu la :");
            double dcsdl = double.Parse(Console.ReadLine());
            ListSV.Add(new sinhvien(ID,HoTen,Ns,dlt,dcsdl));
            return ListSV;
        }

        public void displaySV()
        {
            foreach(sinhvien sv in ListSV)
            {
                Console.WriteLine("ID :{0}, HoTen :{1},Namsinh :{2},diem trung bình:{3}",sv.ID1,sv.Hoten1,sv.Ns1,sv.DTB(sv.Dlt,sv.Dcsdl));
            }    
        }
        public void lietkeSV()
        {
            foreach(sinhvien sv in ListSV)
            {
                if(sv.DTB(sv.Dlt,sv.Dcsdl) >= 8)
                {
                    Console.WriteLine("ID :{0}, HoTen :{1},Namsinh :{2},diem trung bình:{3}", sv.ID1, sv.Hoten1, sv.Ns1, sv.DTB(sv.Dlt, sv.Dcsdl));
                }    
            }    
        }
        public class compareID : IComparer<sinhvien>
        {
            int IComparer<sinhvien>.Compare(sinhvien x, sinhvien y)
        {
                if(x.ID1 == y.ID1)
                {
                    return 0;
                }
                else
                {
                    if (x.ID1 > y.ID1)
                    {
                        return 1;
                    }
                }
                return -1;
            }
            
        }
        public void arrgeID()
        {
            List<sinhvien> lssx = new List<sinhvien>();
            lssx.AddRange(ListSV);
            lssx.Sort(new compareID());
            foreach(sinhvien sv in lssx)
            {
                Console.WriteLine("ID :{0}, HoTen :{1},Namsinh :{2},diem trung bình:{3}", sv.ID1, sv.Hoten1, sv.Ns1, sv.DTB(sv.Dlt, sv.Dcsdl));
            }    
        }
    }
}
