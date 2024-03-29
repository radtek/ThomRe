﻿using VAV.Web.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace VAV.Test
{
    
    
    /// <summary>
    ///This is a test class for UIGeneratorTest and is intended
    ///to contain all UIGeneratorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class UIGeneratorTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FormatCellValue
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Code\\VAV\\trunk\\Src\\VAV\\VAV.Web", "/")]
        [UrlToTest("http://localhost:3222/")]
        public void FormatCellValueTest()
        {
            object dataValue = new DateTime(2014,5,18); // TODO: Initialize to an appropriate value
            string type = "datetime"; // TODO: Initialize to an appropriate value
            string displayFormat = "yyyy-MM"; // TODO: Initialize to an appropriate value
            string expected = "2014-05"; // TODO: Initialize to an appropriate value
            string actual;
            actual = UIGenerator.FormatCellValue(dataValue, type, displayFormat);
            Assert.AreEqual(expected, actual);
        }

    }
}
