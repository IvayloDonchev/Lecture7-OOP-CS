using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double Size => Math.Sqrt(X * X + Y * Y);
        public static Vector operator +(Vector v1, Vector v2) => new Vector(v1.X+v2.X, v1.Y+v2.Y);
        public static Vector operator -(Vector v1, Vector v2) => new Vector(v1.X - v2.X, v1.Y - v2.Y);
        public static bool operator <(Vector v1, Vector v2) => v1.Size < v2.Size;
        public static bool operator >(Vector v1, Vector v2) => v1.Size > v2.Size;
        public static bool operator ==(Vector v1, Vector v2) => v1.Size == v2.Size;
        public static bool operator !=(Vector v1, Vector v2) => v1.Size != v2.Size;
        public override bool Equals(object obj)
        {
            return this.Size == (obj as Vector).Size;
        }
        public override int GetHashCode()
        {
            return (int)(X*X + Y*Y);
        }
    }
}
