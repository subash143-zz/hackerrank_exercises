// https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=strings&isFullScreen=true
// Making Amagrams

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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
      var retVal = 0;
      List<char> a_list = a.Select(x=>x).ToList();
      List<char> b_list = b.Select(x=>x).ToList();
      foreach(char c in a_list){
        if(b_list.Contains(c)){
          b_list.Remove(c);
          retVal += 2;
        }
      }
      return a.Length + b.Length - retVal;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
