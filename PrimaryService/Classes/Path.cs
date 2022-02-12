using System;
namespace TextBasedGame
{
    /*
    * This is a singly-linked List
    * It is the path that the player takes, this is will make it easier to go back 
    */
    internal class Node
    {
        internal Node next;
        internal Place Data; //using internal keyword so we don't have to initialize an object that references this class in class path
    }

    public class Path
    {

        internal Node head;//first node
        public int Count;//count of nodes

        //default constructor
        public Path()
        {
        }

        public void AddAtLast(Place data)
        {
            //we create a new node with inserted data 
            Node newNode = new Node();
            newNode.Data = data;
            //check if the list is empty
            if (head == null)
            {
                head = newNode;//then insert the new node in the head of the list
                Count++;
                return;
            }
            Node lastNode = head;
            //traverse till we get the last node
            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = newNode;//add the inserted node after the last node
            Count++;
        }
        //Prints everything inside the List
        public void PrintAll()
        {
            Node curr = head;
            Console.Write($"Head -> {curr.Data}");
            if (curr.next == null)
            {
                Console.Write(curr.Data);
                Console.Write("->");
            }
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        //removes last node unless it's the head node
        //the List can never be empty
        public void RemoveLast()
        {
            Node node = head;
            Node oldNode = node;
            if (head == null)
            {
                return;
            }
            if (head.next == null)
            {
                Console.WriteLine("\nYou can't go back anymore");
                return;
            }
            while (node.next != null)
            {
                oldNode = node;
                node = node.next;
            }
            oldNode.next = null;
            Count--;
        }
        //gets last node's Data
        public Place getLastPlace()
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            return curr.Data;
        }
        //get first place
        public Place getFirstPlace()
        {
            return head.Data;
        }
        //gets how many nodes are there
        public int getCount()
        {
            return Count;
        }

    }


}