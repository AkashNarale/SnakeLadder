using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class snakeUC2
    {
        public static void UC2()
        {
                Random random = new Random();
                int x = random.Next(1, 7);
                Console.WriteLine("Player1 Roll is :" + x);
        }
    }
}
