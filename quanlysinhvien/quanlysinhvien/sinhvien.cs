using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace quanlysinhvien
{
    class sinhvien
    {
        private int ID;
        private string Hoten;
        private int Ns;
        private double dlt;
        private double dcsdl;

        public int ID1 { get => ID; set => ID = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public int Ns1 { get => Ns; set => Ns = value; }
        public double Dlt { get => dlt; set => dlt = value; }
        public double Dcsdl { get => dcsdl; set => dcsdl = value; }

        
        public sinhvien()
        {

        }

        public sinhvien(int iD, string hoTen, int ns, double dlt, double dcsdl)
        {
            ID = iD;
            Hoten = hoTen;
            Ns = ns;
            this.dlt = dlt;
            this.dcsdl = dcsdl;
        }

        public double DTB(double dlt, double dcsdl)
        {
            return (double)((dlt + dcsdl) / 2);
        }

       
    }
}
