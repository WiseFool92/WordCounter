using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Word { get; set; }
    public string Sentence { get; set; }
    public string ParseWord { get; set; }
    public string ParsedSentence {get; set; }
    
    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
    }
    public bool WordConfirmation()
    {
      foreach (char letter in Word)
      {
        if (char.IsDigit(letter))
        {
          return false;
        }
      }
      return true;      
    }
  }
}