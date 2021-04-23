using System;
using System.ComponentModel.DataAnnotations;

namespace ExceptionExample {
    class Program {

        static void Main(string[] args) {
            try {
                Method2();
            } catch(Exception ex) {
                Console.WriteLine("Ex handled in Main()");
            }
        }

        static void Method1() {
            Method2();
        }

        static void Method2() {
            Method3();
        }

        static void Method3() {
            var n = 1;
            var d = 0;
            var x = n / d;
        }

    } // end of class

}
