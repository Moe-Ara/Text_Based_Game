using System;
namespace TextBasedGame
{
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

        public void AddAtLast(Place data){
            Node newNode = new Node();
            newNode.Data= data;
            current.next= newNode;
            current= newNode;
            index++;
        }
        public void PrintAll(){
            Console.Write("Head ->");
            Node curr =head;
            while(curr.next!=null){
                curr=curr.next;
                Console.Write(curr.Data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        public void RemoveLast(){
            Node curr=head;
            while(curr.next.next!=null){
                curr=curr.next;
            }
            curr.next=null;
        }
        public Place getLast(){
            Node curr=head;
            while(curr.next!=null){
                curr= curr.next;
            }
            return curr.Data;
        }

    }


}