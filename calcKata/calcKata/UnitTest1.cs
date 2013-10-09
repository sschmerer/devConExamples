using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calcKata
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestMethod1()
      {
         string input = "";
         int result = returnZero(input);
         Assert.AreEqual( 0, result );
      }

      private int returnZero( string input )
      {
         return 0;
      }
   }
}
