using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace JogoDaForca
{
  public static class Archive
  {
    public static readonly string Path = Directory.GetCurrentDirectory();
    public static readonly string NameOfFile = @"\Words.txt";

    public static void InsertWord(string word)
    {

      if (!File.Exists(Path + NameOfFile))
      {
        using (var file = new StreamWriter(Path + NameOfFile))
        {
          file.WriteLine(word);
        }
      }
      else
      {
        using (var file = File.AppendText(Path + NameOfFile))
        {
          file.WriteLine(word);
        }
      }
    }

    public static List<string> GetSomeWord()
    {
      var list = new List<string>();
      //TODO
      return list;
    }

    public static void RemoveLastWord()
    {
      //TODO

    }
  }
}