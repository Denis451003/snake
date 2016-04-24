using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine leftline = new HorizontalLine( 0, 78, 0, '+');
            HorizontalLine rightline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine upline = new VerticalLine(0, 24, 0, '+');
            VerticalLine downline = new VerticalLine(0, 24, 78, '+');
            leftline.Drow();
            rightline.Drow();
            upline.Drow();
            downline.Drow();
                
            Console.ReadKey( );
        }

    }
}
