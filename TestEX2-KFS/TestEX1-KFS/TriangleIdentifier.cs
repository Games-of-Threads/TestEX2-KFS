using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX2_KFS
{
    public class TriangleIdentifier
    {
        public bool IsRunning { get; set; }

        //public static int derp;

        int a, b, c;

        string state;

        public TriangleIdentifier()
        {
            state = "start";
            IsRunning = true;
        }

        public void Triangle()
        {
            switch (state)
            {
                case "start":
                    Console.Clear();
                    a = 0;
                    b = 0;
                    c = 0;
                    Console.WriteLine("welcome! please type your choice of action then press enter to continue\n go: starts the main purpose of the program.\n exit: closes down the application.");
                    state = Console.ReadLine();
                    break;
                case "go":
                    Console.WriteLine("please insert 3 indidual values in sequence followed by enter");
                    try
                    {
                        TriangleCalculate(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                    }
                    catch
                    {
                        ErrorReport("only integers allowed");
                        break;;
                    }
                    state = "start";
                    Console.ReadKey();
                    break;
                case "exit":
                    IsRunning = false;
                    break;
                default:
                    state = "start";
                    break;
            }
        }

        public void TriangleCalculate(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.a = a;
                this.b = b;
                this.c = c;
                if (TriangleEquilateral(a, b, c))
                {
                    TriangleReport("Scalene", "all sides are different");
                }
                else if (TriangleScalene(a, b, c))
                {
                    TriangleReport("Scalene", "all sides are different");
                }
                else
                {
                    TriangleReport("isosceles", "2 sides are relative yet the last isn't");
                }
            }
        }

        public bool TriangleEquilateral(int a,int b, int c)
        {
            if (a == b && b == c && a == c)
            {
                return true;
            }

            return false;
        }

        public bool TriangleScalene(int a, int b, int c)
        {
            if (a != b && a != c && b != c)
            {
                return true;
            }
            return false;
        }

        public void TriangleReport(string report, string reason)
        {
            Console.WriteLine("triangle is {0} since the side values of the triangle are a = {1} b = {2} c = {3} which means {4}",report,a,b,c,reason);
        }

        public void ErrorReport(string report)
        {
            Console.WriteLine("sorry sir we encountered a error in {0} resetting back to start, press enter to continue",report);
            Console.ReadKey();
            state = "start";
        }

        public void InvalidReport()
        {
            Console.WriteLine("sorry sir that input is invalid, resetting back to start, press enter to continue");
            Console.ReadKey();
            state = "start";
        }
    }
}
