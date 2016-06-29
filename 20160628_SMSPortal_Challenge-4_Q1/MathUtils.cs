using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SMSPortal_Challenge4 {
    class MathUtils {
        public static double Average(double a, double b) {
            return (a + b) / 2;
        }

        public static void Main(string[] args) {
            Console.WriteLine(Average(2, 1));
            Console.ReadLine();
        }
    }
}