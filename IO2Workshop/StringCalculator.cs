using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO2Workshop
{
    public class StringCalculator
    {
        public static int sumString(string str)
        {
            if (str == String.Empty)
            {
                return 0;
            }

            int res = 0;
            if(Int32.TryParse(str, out res))
            {
                return res;
            }

            //if (str.Contains(','))
            //{
            //    var splitted = str.Split(',');
            //    int sum = 0;
            //    foreach (var item in splitted)
            //    {
            //        sum += Int32.Parse(item);
            //    }

            //    return sum;
            //}

            //if (str.Contains('\n'))
            //{
            //    var splitted = str.Split('\n');
            //    int sum = 0;
            //    foreach (var item in splitted)
            //    {
            //        sum += Int32.Parse(item);
            //    }

            //    return sum;
            //}

            int sum = 0;
            string[] splitted;
            if (str.Substring(0, 2) == "//")
            {
                 splitted = str.Substring(4).Split(',', '\n', str[3]);
            }
            else
            {
                 splitted = str.Split(',', '\n');

            }
            foreach (var item in splitted)
            {
                int val = int.Parse(item);
                if (val < 0)
                    throw new ArgumentException();
                if(val>1000)
                {
                    continue;
                }
                sum += val;
            }

            return sum;

        }
    }
}
