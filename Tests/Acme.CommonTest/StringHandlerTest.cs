using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Acme.common;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void StringHandlerTest()
        {
            // Arrange
            var source = "AbelTadesse";
            var expected = "Abel Tadesse";
            var handler = new StringHandler(); 

        }
    }
}
