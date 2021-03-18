// https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=recursion-backtracking&isFullScreen=true

using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {
      if(n == 1) return 0;
      if(n ==2 ) return 1;
      int a = 0;
      int b = 1;
      int c = a + b;
      for(int i = 2; i <= n; i++){
        c = a + b;
        a = b;
        b = c;
      }
      return c;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}