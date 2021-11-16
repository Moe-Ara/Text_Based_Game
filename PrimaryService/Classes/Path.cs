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
        internal Place Data;
    }

    public class Path
    {

        internal Node head;
        private Node current;
        public int index;

        public Path()
        {
            head = new Node();
            current = head;

        }

        public void AddAtLast(Place data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            current.next = newNode;
            current = newNode;
            index++;
        }
        public void PrintAll()
        {
            Console.Write("Head ->");
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        public void RemoveLast()
        {
            Node curr = head;
            //traverse until you find the last node
            while (curr.next.next != null)
            {
                curr = curr.next;
            }
            //if they are at the start
            if (curr.next == null)
            {
                Console.WriteLine("You can't go back any further");
                return;
            }
            curr.next = null;
        }
        public Place getLast()
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            return curr.Data;
        }

    }


}