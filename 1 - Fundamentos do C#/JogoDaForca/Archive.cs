using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace JogoDaForca
{
  public static class Archive
  {
    public static readonly string CurrentPath = Directory.GetCurrentDirectory();
    public static readonly string NameOfFile = @"\Words.txt";
    public static readonly string FilePath = CurrentPath + NameOfFile;

    public static void InsertWord(string word)
    {
      if (!word.Contains("-"))
      {
        ErrorHandling.HasError("Voce não colocou o \"-\" !!");
        return;
      }

      if (!File.Exists(FilePath))
      {
        using (var file = new StreamWriter(FilePath))
        {
          File.SetAttributes(FilePath, FileAttributes.Hidden);
          file.WriteLine(word);
        }
      }
      else
      {
        using (var file = File.AppendText(FilePath))
        {
          file.WriteLine(word);
        }
      }
    }

    public static string[] GetSomeWord()
    {
      string[] list = new string[2];
      var random = new Random();
      var wordChoice = "";
      //var list = new List<string>();

      if (!File.Exists(FilePath)) ErrorHandling.HasError("Não há palavras cadastradas !");

      using (var file = new StreamReader(FilePath))
      {
        var lines = File.ReadAllLines(FilePath);

        if (lines.Length <= 0)
        {
          ErrorHandling.HasError("Não há mais palavras.");
          return null;
        }

        wordChoice = lines[random.Next(0, lines.Length)];
      }

      list[0] = wordChoice.Substring(0, wordChoice.IndexOf("-"));
      list[1] = wordChoice.Substring(wordChoice.IndexOf("-") + 1, (wordChoice.Length - 1) - list[0].Length);

      return list;
    }

    public static void RemoveLastWord()
    {
      if (File.Exists(FilePath))
      {
        var newArchive = "";

        using (var file = new StreamReader(FilePath))
        {
          var lines = File.ReadAllLines(FilePath);
          File.SetAttributes(FilePath, FileAttributes.Normal);

          if (lines.Length <= 0)
          {
            File.SetAttributes(FilePath, FileAttributes.Hidden);
            ErrorHandling.HasError("Não há mais palavras.");
            return;
          }

          for (int i = 0; i < lines.Length - 1; i++)
          {
            newArchive += lines[i];
            newArchive += "\n";
          }
        }
        using (var file = new StreamWriter(FilePath))
        {
          file.Write(newArchive);
          File.SetAttributes(FilePath, FileAttributes.Hidden);
        }
      }
    }
  }
}