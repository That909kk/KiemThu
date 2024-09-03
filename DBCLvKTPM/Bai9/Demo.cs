using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    public class Demo
    {
        
        public static void Main()
        {
            Bai9 bai9 = new Bai9();
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", 5, 5)); // Kết quả: "Hello"
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", 2, 3)); // Kết quả: "Helrld"
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", 5, 0)); // Kết quả: "World"
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", 5, 20)); // Kết quả: "HelloWorld"
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", 5, -1)); // Kết quả: "HelloWorld"
            Console.WriteLine(bai9.HuyChuoi("HelloWorld", -5, 5)); // Kết quả: "HelloWorld"
        }
    }
}
