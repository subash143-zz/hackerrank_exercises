# https://www.hackerrank.com/challenges/ctci-comparator-sorting/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting

from functools import cmp_to_key
class Player:
    def __init__(self, name, score):
        self.name = name
        self.score = score
    def __repr__(self):
        return self.name
      
    def comparator(a, b):
        if(a.score > b.score):
          return -1
        elif a.score < b.score:
          return 1
        else:
          i = 0
          while i < len(a.name) and i < len(b.name):
            if a.name[i] > b.name[i]:
              return 1
            elif(a.name[i] < b.name[i]):
              return -1
            i = i + 1
        
          return 1 if len(a.name) > len(b.name) else -1
          
n = int(input())