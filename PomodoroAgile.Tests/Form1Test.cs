// <copyright file="Form1Test.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using NUnit.Framework;
using PomodoroAgile;

namespace PomodoroAgile.Tests
{
    /// <summary>이 클래스에는 Form1에 대해 매개 변수가 있는 단위 테스트가 들어 있습니다.</summary>
    [PexClass(typeof(Form1))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestFixture]
    public partial class Form1Test
    {
        Form1 target;
        [SetUp]
        public void setup()
        {
            target = new Form1();
        }
        /// <summary>.ctor()에 대한 테스트 스텁</summary>
        [PexMethod]
        public Form1 ConstructorTest()
        {
            Form1 target = new Form1();
            return target;
            // TODO: Form1Test.ConstructorTest() 메서드에 어설션 추가
        }

        [Test, Description("winform test1")]
        public void test1()
        {
            Assert.AreEqual(1, target.myint);
            target.myint = 2;
        }

        [Test, Description("winform test1")]
        public void test2()
        {
            Assert.AreEqual(1, target.myint);
        }
    }

}

