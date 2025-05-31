using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLINKED_053125
    {
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

    public class MyLinkedList 
    {
        // A 'head' is a naming why of saying the first item in the list
        // A starting point is another way of looking at it. 
        private Node _head;
    }
}
