
using System;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        
        // setup
        private Math _math;

        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }
        
        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            
            // act
            var result = _math.Add(1, 2);
            // assert
            Assert.That(result, Is.EqualTo(3));
            
            Assert.True(true);
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2, 2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedValue)
        {
            
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedValue));
        }
        
    }
}