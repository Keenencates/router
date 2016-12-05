using System;

namespace router.com.system
{
    public class point
    {
        private double x, y;


        public point(double x , double y) { this.x = x; this.y = y; }
        public double getLongitude() { return x; }
        public double getLatitude() { return y; }
        public double disTo(point point)
        {
            return Math.Sqrt(Math.Pow(point.getLongitude() - this.x, 2) + Math.Pow(point.getLatitude() - this.y, 2));
        }
        public string ToString()
        {
            return "(" + x.ToString() + ", " + y.ToString() + " )";
        }

    }
}