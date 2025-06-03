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
            myLinkedList = EstablishTheLinkedList();
            Console.WriteLine("\nmyLinkedList ends at: ");
            myLinkedList.PrintAll();

        }

        public void ShowLastValueInALinkedList()
        {
            Node lastValue = EstablishTheLinkedList().GetLastValue();
            Console.WriteLine($"\nThe last value myLinkedList is: {lastValue._value}");

        }

        public void GetInputAndCheckForNumber()
        {
            SinglyLinkedList myLinkedList = EstablishTheLinkedList();

            Console.WriteLine("Enter a Number and we'll see if it's in the existing list");
            int targetNum = int.Parse(Console.ReadLine());

            bool succes = myLinkedList.Contains(targetNum);

            if (succes) 
            {
                Console.WriteLine($"Your number, {targetNum}, was in the List!");
            }

            else
            {
                Console.WriteLine("Not finding a match :( ");
            }
        }

        // I didn't want to keep writing the same instance 
        // on each of the methods within gptLINKED 
        // so I did this method to do that for me and then return a 
        // SinglyLinkedList
        private SinglyLinkedList EstablishTheLinkedList()
        {
            SinglyLinkedList establishedList = new SinglyLinkedList();

            Console.WriteLine("Starting to create the Linked List");

            Console.WriteLine("\nFirst call is myLinkedList.Add(5)");
            establishedList.Add(5);

            Console.WriteLine("\nSecond call is myLinkedList.Add(10)");
            establishedList.Add(10);

            Console.WriteLine("\nThird call is myLinkedList.Add(20)");
            establishedList.Add(20);

            return establishedList;
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

            // Step 3. If the list isn't empty then we create a reference
            Node current = _head;
            // This will only run if ._next has a Node object 
            while (current._next != null)
            {
                // This moves us till we get to the end of the list
                // Remember the end of the list is always ending with null in "next" 
                // Like so: 
                // Node:
                // [
                //  {value: 5, next: ---pointer/reference---> {value: 10, next: null}},
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

        // You're just getting the last value in the list
        public Node GetLastValue()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty. No last value to return.");
                return null;
            }

            // When we get to here,
            // Then there is already an object in memory called "_head"
            // So we create a reference to point to that memory spot 
            // But "current" isn't a copy of "_head" it's just a reference, a pointer. 
            Node current = _head;

            while (current._next != null)
            {
                // This is what moves the list forward 
                // Remember ._next at this point already exists in memory 
                // Due to us assigning current to "_head" 
                current = current._next;
            }

            // And since we just want the last time of the list
            // we just need the list to get to the end with that while loop 
            // and then just return it. 
            return current;
        }

        public bool Contains(int targetNum) 
        {
            Node current = _head;

            while (current != null) 
            {
                if (current._value == targetNum)
                {
                    return true;
                }

                current = current._next;
            }
            return false;
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
