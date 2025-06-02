using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLINKED_053125
    {
        SinglyLinkedList myLinkedList = new SinglyLinkedList();

        public void ShowSinglyLinkedLists() 
        {
            Console.WriteLine("Starting to create the Linked List");
            

            Console.WriteLine("\nFirst call is myLinkedList.Add(5)");
            myLinkedList.Add(5);

            Console.WriteLine("myLinkedList currently is at: ");
            myLinkedList.PrintAll();

            Console.WriteLine("\nSecond call is myLinkedList.Add(10)");
            myLinkedList.Add(10);

            Console.WriteLine("myLinkedList currently is at: ");
            myLinkedList.PrintAll();

            Console.WriteLine("\nThird call is myLinkedList.Add(20)");
            myLinkedList.Add(20);

            Console.WriteLine("myLinkedList currently is at: ");
            myLinkedList.PrintAll();

            Console.WriteLine("\nmyLinkedList ends at: ");
            myLinkedList.PrintAll();

        }

        public void ShowLastValueInALinkedList() 
        {
            Console.WriteLine($"The last value myLinkedList is: {myLinkedList.GetLastValue()}");

        }
    }

    public class SinglyLinkedList 
    {
        // A 'head' is a naming why of saying the first item in the list
        // A starting point is another way of looking at it. 
        private Node _head;
        
        // Here is where we'll do the logic getting the values added in the correct spot 
        // And setting up each node to have the _next pointer
        public void Add(int value) 
        {
            // Step 1. Create a new Node and set it to the value of the parameter from Add
            Node newNode = new Node(value, null); 

            // Step 2. We need to see if this linked list is empty or not. 
            if (_head == null) 
            {
                // If it is empty then set it to _head so we can start building the linked list
                _head = newNode;
                return;
            }

            // Step 3. If the list isn't empty then we create a reference (or a pointer?)
            Node current = _head;
            // This will only run if ._next has a Node object 
            while (current._next != null) 
            {
                // This moves us till we get to the end of the list
                // Remember the end of the list is always ending with null in "next" 
                // Like so: 
                // Node:
                // [
                //  {value: 5, next:
                //              {value: 10, next: null}},
                //  {value: 10, next: null}
                // ]
                current = current._next;
            }

            // Then to end it, we finally set the last entry in the Node to have Null 
            current._next = newNode;
        }

        // This logic is to print all the objects in the linked list
        public void PrintAll() 
        {
            Node current = _head;

            while (current != null) 
            {
                Console.WriteLine($"Value: {current._value}");
                current = current._next;
            }
        }

        public Node GetLastValue() 
        {
            Node current = _head;

            while (current._next != null) 
            {
                current = current._next;
            }

            return current;
        }
    }
    
    public class Node
    {
        public int _value;

        // This isn't recursion, just a self-referential data structure.
        // Very common when modeling chains, trees, graphs, etc.
        public Node _next;

        public Node(int value, Node next)
        {
            _value = value;
            _next = next;
        }
    }
}
