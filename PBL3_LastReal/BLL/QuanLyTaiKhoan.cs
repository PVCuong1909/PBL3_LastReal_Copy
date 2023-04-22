using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PBL3_LastReal.BLL
{
    internal class QuanLyTaiKhoan
    {
        public static string MD5Hash(string input)
        {
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public bool CheckTienTaiKhoan(int Money)
        {
            bool result = false;
            if (Money > 0)
            {
                result = true;
            }
            return result;
        }
        public List<String> GetID_May()
        {
            List<String> list = new List<string>();
            QuanLyNetDataContext db = new QuanLyNetDataContext();
            foreach (Computer i in db.Computers)
            {
                list.Add(i.ID_Computer.ToString());
            }
            return list;
        }
    }
}
