using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3._2_Stack
{
    public class Stack
    {
        StringNode head;
        StringNode tail;

        public Stack()
        {
            head = null;
            tail = null;
        }

        //adds new string to the stack
        public void Push(string newString)
        {
            StringNode newNode = new StringNode(newString);
            //if stack is empty
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        //Returns the most recently added string, and removes it from the stack
        public string Pop()
        {
            if (Count() != 0)
            {
                string mostRecent = tail.Data;
                DeleteTail();
                return mostRecent;
            }
            else
            {
                throw new NullReferenceException("There are no items in this collection. Add an item, then try again");
            }
        }

        private void DeleteTail()
        {
            //If you are deleting the first node
            if (tail == head)
            {
                //(it is the only node in the list)
                    //Head and Tail both become null
                    head = null;
                    tail = null;
            }
            else
            {
                StringNode current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;

                //Set Tail to point to the “previous” node, because it is now at the end
                tail = current;
            }
        }

        //Returns the most recently added string, but does not remove it from the stack
        public string Peek()
        {
            if(Count() != 0)
            {
                return tail.Data;
            }
            else
            {
                throw new NullReferenceException("There are no items in this collection. Add an item, then try again");
            }                     
        }

        //Returns the number of strings currently held in the stack
        public int Count()
        {
            int count = 0;
            StringNode current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //Returns true if the stack contains zero elements and false otherwise
        public bool isEmpty()
        {
            return head == null;
        }
    }
}
