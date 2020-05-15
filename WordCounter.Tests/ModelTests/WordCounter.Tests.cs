using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void Contain_WordCollection_Word()
    {
      // Arrange
      string freshWord = "antelope";
      RepeatCounter testCheck = new RepeatCounter(freshWord, "test");
      // Act
      string result = testCheck.Word;
      //Assert
      Assert.AreEqual(freshWord, "dog"); 
    }
  }
}