using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170_Assignment02
{
    class TriangleSolver
    {
        public static string Analyze(int side1, int side2, int side3)
        {
            // Validate all sides must be greated then 0
            if ((side1 <= 0) || (side2 <= 0) || (side3 <= 0))
            {
                return "Do not form a triangle";
            }

            // Check if triangle is Equilateral
            if (IsEquilateral(side1, side2, side3))
            {
                return "Equilateral";
            }

            // Check if triangle is Isosceles
            if (IsIsosceles(side1, side2, side3))
            {
                return "Isosceles";
            }

            // Check if triangle is Scalene
            if (IsScalene(side1, side2, side3))
            {
                return "Scalene";
            }
            return "Do not form a triangle";
        }
        private static bool IsEquilateral(int side1, int side2, int side3)
        {
            if ((side1 == side2) && (side2 == side3))
            {
                return true;
            }
            return false;
        }
        private static bool IsIsosceles(int side1, int side2, int side3)
        {
            if ((side1 == side2) || (side1 == side3) || (side2 == side3))
            {
                return true;
            }
            return false;
        }
        private static bool IsScalene(int side1, int side2, int side3)
        {
            if ((side1 != side2) && (side1 != side3) && (side2 != side3))
            {
                return true;
            }
            return false;
        }
    }
}
