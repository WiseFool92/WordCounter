using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    [TestMethod]
    public void Dispose()
    {
      ItemTests.ClearAll();
    }
  }
}