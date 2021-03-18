// https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
// 

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
      var noteDic = note.GroupBy(x=>x).ToDictionary(y=>y.Key, y=>y.Count());
      var magDict = magazine.GroupBy(x=>x).ToDictionary(y=>y.Key, y=>y.Count());
      
      foreach(var noteItem in noteDic){
        if(!magDict.ContainsKey(noteItem.Key)){
          Console.WriteLine("No");
          return;
        }
        else if(noteItem.Value > magDict[noteItem.Key]){
          Console.WriteLine("No");
          return;
        }
      }
      
      Console.WriteLine("Yes");      
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
