using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_Assignment02;
using NUnit.Framework;


namespace PROG8170_Assignment02.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeTest_input_0_0_0_Expect_Do_not_form_a_triangle()
        {
            // Arrange 
            int side1 = 0;
            int sise2 = 0;
            int side3 = 0;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Do not form a triangle");
        }

        [Test]
        public void AnalyzeTest_input_0_15_50_Expect_Do_not_form_a_triangle()
        {
            // Arrange 
            int side1 = 0;
            int sise2 = 15;
            int side3 = 50;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Do not form a triangle");
        }

        [Test]
        public void AnalyzeTest_input_8_12_16_Expect_Scalene()
        {
            // Arrange 
            int side1 = 8;
            int sise2 = 12;
            int side3 = 16;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Scalene");
        }

        [Test]
        public void AnalyzeTest_input_800_1500_500_Expect_Scalene()
        {
            // Arrange 
            int side1 = 800;
            int sise2 = 1500;
            int side3 = 500;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Scalene");
        }

        [Test]
        public void AnalyzeTest_input_6_6_15_Expect_Isosceles()
        {
            // Arrange 
            int side1 = 6;
            int sise2 = 6;
            int side3 = 15;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Isosceles");
        }

        [Test]
        public void AnalyzeTest_input_999_999_1200_Expect_Isosceles()
        {
            // Arrange 
            int side1 = 900;
            int sise2 = 900;
            int side3 = 1200;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Isosceles");
        }



        [Test]
        public void AnalyzeTest_input_9_9_9_Expect_Equilateral()
        {
            // Arrange 
            int side1 = 9;
            int sise2 = 9;
            int side3 = 9;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Equilateral");
        }

        [Test]
        public void AnalyzeTest_input_900_900_900_Expect_Equilateral()
        {
            // Arrange 
            int side1 = 900;
            int sise2 = 900;
            int side3 = 900;
            // Act
            string response = TriangleSolver.Analyze(side1, sise2, side3);
            //Assert
            Assert.AreEqual(response, "Equilateral");
        }
    }
}
