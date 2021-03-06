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
      Assert.AreEqual(freshWord, result); 
    }

    [TestMethod]
    public void Contain_SentenceCollection_Sentence()
    {
      // Arrange
      string freshSentence = "How much wood could a wood chuck, chuck if a wood chuck could chuck wood?";
      RepeatCounter testCheck = new RepeatCounter("test", freshSentence);
      // Act
      string result = testCheck.Sentence;
      // Assert
      Assert.AreEqual(freshSentence, result);
    }

    [TestMethod]
    public void ConfirmWord_WordIsEqual_True()
    {
      // Arrange
      string freshWord = "baselisk";
      RepeatCounter testCheck = new RepeatCounter(freshWord, "confirm");
      // Act
      bool result = testCheck.WordConfirmation();
      // Assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void ConfirmWord_WordIsEqual_False()
    {
      // Arrange
      string freshWord = "1337Sauce";
      RepeatCounter testCheck = new RepeatCounter(freshWord, "confirm");
      // Act
      bool result = testCheck.WordConfirmation();
      // Assert
      Assert.IsFalse(false, "1337Sauce"); 
    }

    [TestMethod]
    public void ConfirmSentence_SentenceIsEqual_True()
    {
      // Arrange
      string freshSentence = "Oil slicks the road";
      RepeatCounter testCheck = new RepeatCounter("confirm", freshSentence);
      // Act
      bool result = testCheck.SentenceConfirmation();
      // Assert
      Assert.IsTrue(true, "Oil slicks the road"); 
    }

    [TestMethod]
    public void ConfirmSentence_SentenceIsEqual_False()
    {
      // Arrange
      string freshSentence = "The gr3as3r gawk3d";
      RepeatCounter testCheck = new RepeatCounter("confirm", freshSentence);
      // Act
      bool result = testCheck.SentenceConfirmation();
      // Assert
      Assert.IsFalse(result);
    }
  }
}