using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibrary.Test
{
  [TestClass]
  public class SampleTest
  {
    [TestMethod]
    public void TestSay()
    {
      var sample = new Sample();
      sample.Say().Is("Hello TDD Boot Camp!");
    }
  }
}
