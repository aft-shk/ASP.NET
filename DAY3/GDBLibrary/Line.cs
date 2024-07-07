using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GDBLibrary
{
    public  sealed class Line : Shape, Istorable,Iprintable
    {
        //Auto Property
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }

        private int thickness;

        public static int count;
        public int Thickness
        {
            get
            {
                return thickness;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Line can not have negative value");
                }
                this.thickness = value;
            }
        
        }
       



        public Line()
        {
            count++;
            this.StartPoint = new Point();
            this.EndPoint = new Point();
            this.Thickness = thickness;
        }

        public Line(Point stpoint, Point endpoint, int thickness)
        {
            count++;
            this.StartPoint = stpoint;
            this.EndPoint = endpoint;
            this.Thickness = thickness;
        }
        public override void Draw()
        {
            Console.WriteLine("this is Line");
        }

        
        public override string ToString()
        {
            return " Point P1:"+ this.StartPoint.ToString()+ "  Point P2:" +
                this.EndPoint.ToString()+"  Thickness: "+
                this.Thickness;
        }

        public void Store()
        {
            
        }

        public void Print()
        {
            
        }
    }
}
