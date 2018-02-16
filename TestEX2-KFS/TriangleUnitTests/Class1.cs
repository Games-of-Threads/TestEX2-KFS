using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestEX2_KFS;

namespace TriangleUnitTests
{
    public class Class1
    {

        [Fact]
        public void TriangleEquilateralTest1()
        {
            Assert.True(new TriangleIdentifier().TriangleEquilateral(1,1,1));
        }

        [Fact]
        public void TriangleEquilateralTest2()
        {
            Assert.False(new TriangleIdentifier().TriangleEquilateral(1,2,3));
        }

        [Fact]
        public void TriangleEquilateralTest3()
        {
            int a = 1, b = 1, c = 1;
            Assert.NotInRange(a, int.MinValue, 0);
            Assert.NotInRange(b, int.MinValue, 0);
            Assert.NotInRange(c, int.MinValue, 0);
            Assert.True(new TriangleIdentifier().TriangleEquilateral(a, b, c));
        }

        [Fact]
        public void TriangleScaleneTest1()
        {
            int a = 1, b = 1, c = 1;
            Assert.False(new TriangleIdentifier().TriangleScalene(a, b, c));
        }

        [Fact]
        public void TriangleScaleneTest2()
        {
            int a = 1, b = 3, c = 1;
            Assert.False(new TriangleIdentifier().TriangleScalene(a, b, c));
        }

        [Fact]
        public void TriangleScaleneTest3()
        {
            int a = 1, b = 2, c = 3;
            Assert.True(new TriangleIdentifier().TriangleScalene(a, b, c));
        }

        [Fact]
        public void TriangleInputTest1()
        {
            TriangleIdentifier t = new TriangleIdentifier();
            Action act = () => t.TriangleCalculate(0, 2, 1);
            Assert.Throws<ArgumentException>(act);
        }
    }
}
