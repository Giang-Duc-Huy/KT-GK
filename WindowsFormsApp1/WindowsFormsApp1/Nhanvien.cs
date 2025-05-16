using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Nhanvien
    {
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public string eMail { get; set; }   
        public Nhanvien(string maso, string hoten, DateTime ngaysinh, string email) {
            maSo = maso;
            hoTen = hoten;
            ngaySinh = ngaysinh;
            eMail = email;
        }
        public override string ToString()
        {
            return $"{maSo} - {hoTen} - {ngaySinh:dd/MM/yyyy} - {eMail}";
        }
    }
}
