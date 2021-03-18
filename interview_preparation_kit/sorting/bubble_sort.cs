// https://www.hackerrank.com/challenges/ctci-bubble-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting

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

    // Complete the countSwaps function below.
    static void countSwaps(int[] a) {
      int swaps = 0;
      for(int i = 0; i < a.Count(); i++){
        for(int j = i+1; j < a.Count(); j++){
          if(a[i] > a[j]){
            var temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            swaps++;
          }
        }
      }
      Console.WriteLine($"Array is sorted in {swaps} swaps.");
      Console.WriteLine($"First Element: {a[0]}");
      Console.WriteLine($"Last Element: {a[a.Count()-1]}");

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        countSwaps(a);
    }
}
