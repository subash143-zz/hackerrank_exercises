// https://www.hackerrank.com/challenges/insert-a-node-into-a-sorted-doubly-linked-list/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=linked-lists&isFullScreen=true

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

    class DoublyLinkedListNode {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData) {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    class DoublyLinkedList {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList() {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData) {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null) {
                this.head = node;
            } else {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }

    static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter) {
        while (node != null) {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null) {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the sortedInsert function below.

    /*
     * For your reference:
     *
     * DoublyLinkedListNode {
     *     int data;
     *     DoublyLinkedListNode next;
     *     DoublyLinkedListNode prev;
     * }
     *
     */
    static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode head, int data) {
      var retVal = head;
      
      //Create new node for insertion
      var newNode = new DoublyLinkedListNode(data);

      //Checkif head node is greater than the current node
      if(head.data > data){
        newNode.next = head;
        head.prev= newNode;
        return newNode;
      }

      //Loop untill it reaches appropriate position
      while(head.next != null && head.next.data < data){
        head = head.next;
      }

      //If reached last, append it to last
      if(head.next == null){
        head.next = newNode;
        newNode.prev = head;
      }

      //If in the middle, make necessary chanes
      else{
        var next = head.next;
        head.next = newNode;
        newNode.next = next;
        next.prev = newNode;
        newNode.prev = head;
      }
      
      return retVal;
            
    }

    static void Main(string[] args) {