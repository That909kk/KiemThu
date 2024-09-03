using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class Bai9
    {
        public Bai9()
        {
        }
        public string HuyChuoi(string s, int n, int p)
        {
            // Kiểm tra điều kiện bất hợp lệ
            if (p < 0 || n < 0 || p >= s.Length)
            {
                return s;
            }

            // Nếu n lớn hơn số ký tự từ vị trí p đến hết chuỗi
            if (n > s.Length - p)
            {
                char[] result = new char[p];
                for (int i = 0; i < p; i++)
                {
                    result[i] = s[i];
                }
                return new string(result);
            }

            // Tạo mảng ký tự để xây dựng chuỗi mới
            char[] newString = new char[s.Length - n];
            int index = 0;

            // Sao chép các ký tự từ đầu đến vị trí p
            for (int i = 0; i < p; i++)
            {
                newString[index++] = s[i];
            }

            // Sao chép các ký tự từ vị trí p + n đến hết chuỗi
            for (int i = p + n; i < s.Length; i++)
            {
                newString[index++] = s[i];
            }

            return new string(newString);
        }
    }
}

