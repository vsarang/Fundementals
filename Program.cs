using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundementals
{
    class Program {
        enum Days { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
        static void Main(string[] args) {
            DateTime dt = DateTime.Now;
            int ms = calcMS(dt) + calcMS(2000, 1, 1);
            TimeSpan step = new TimeSpan(ms);

            DateTime[] dates = new DateTime[10];
            List<NonNegativeInt> seconds = new List<NonNegativeInt>();
            dates[0] = dt;
            for (NonNegativeInt i = new NonNegativeInt(1); i.Get() < 10; i.Set(i.Get() + 1))
            {
                dates[i.Get()] = dates[i.Get() - 1] + step;
                seconds.Add(new ImmutableNonNegativeInt(step.Seconds));
            }

            try {
                StreamReader reader = new StreamReader("data.txt");
                string line = reader.ReadLine();
                do {
                    line = reader.ReadLine();
                    Console.WriteLine(line[3]);
                } while (line != null);
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e.FileName + " does not exist");
            }

            switch (dt.Day)
            {
                case (int)Days.Wed:
                    Console.Write("It's Wednesday!");
                    break;
                case (int)Days.Sat:
                case (int)Days.Sun:
                    Console.Write("It's the weekend!");
                    break;
                default:
                    break;
            }
        }

        private static int calcMS(DateTime dt) {
            return (dt.Second % 2 == 0) ? 2000 : 1200;
        }

        private static int calcMS(int y, int m, int d) {
            return calcMS(new DateTime(y, m, d));
        }
    }
}
