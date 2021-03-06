// <copyright file="MainDemonTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqListCAI.Pages.MainPage;

namespace SqListCAI.Pages.MainPage.Tests
{
    /// <summary>此类包含 MainDemon 的参数化单元测试</summary>
    [PexClass(typeof(MainDemon))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MainDemonTest
    {
        /// <summary>测试 initUI(Int32) 的存根</summary>
        [PexMethod]
        public void initUITest([PexAssumeUnderTest]MainDemon target, int flag)
        {
            target.initUI(flag);
            // TODO: 将断言添加到 方法 MainDemonTest.initUITest(MainDemon, Int32)
        }
    }
}
