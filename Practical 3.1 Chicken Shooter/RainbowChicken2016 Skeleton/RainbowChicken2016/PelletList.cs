using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RainbowChicken2016
{
    public class PelletList
    {
        Pellet headPointer = null;
        Pellet tailPointer = null;

        Rectangle boundsRectangle;

        //==============================================================================
        // Ctor
        //==============================================================================
        public PelletList(Rectangle boundsRectangle)
        {
            this.boundsRectangle = boundsRectangle;
        }

        //==============================================================================
        // Add Pellet newPellet at the end of the list.
        //==============================================================================
        public void addPellet(Pellet newPellet)
        {
            if (headPointer == null)
            {
                headPointer = newPellet;
                tailPointer = newPellet;
            }
            else
            {
                tailPointer.Next = newPellet;
                tailPointer = newPellet;
            }
        }

        //==============================================================================
        // Walk the list, counting the number of Pellet. Return the count.
        //==============================================================================
        public int Count()
        {
            int count = 0;
            Pellet current = headPointer;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //==============================================================================
        // Walk the list, calling the Move() method of each Pellet
        //==============================================================================
        public void Move()
        {
            Pellet current = headPointer;
            while (current != null)
            {
                current.Move();
                current = current.Next;
            }
        }

        //==============================================================================
        // Walk the list. For each Pellet, call TestOutOfBounds, passing boundsRectangle.
        // For each node that is out of bounds, set its IsAlive property to false.
        //==============================================================================
        public void KillOutOfBounds()
        {
            Pellet current = headPointer;
            while (current != null)
            {
                if(current.TestOutOfBounds(boundsRectangle))
                {
                    current.IsAlive = false;
                }
                current = current.Next;
            }
        }

        //==============================================================================
        // Delete the argument Pellet pelletToDelete from the list.
        // Be careful to maintain the integrity of the list, including
        // headPointer and tailPointer.
        //==============================================================================
        public void DeleteOne(Pellet pelletToDelete)
        {
            //If you are deleting the first node
            if (pelletToDelete == headPointer)
            {
                //If it is the only node in the list
                if (Count() == 1)
                {
                    //Head and Tail both become null
                    headPointer = null;
                    tailPointer = null;
                }
                else
                {
                    //Move Head along to the second node
                    headPointer = headPointer.Next;
                }
            }
            else
            {
                Pellet current = headPointer;
                while (current.Next != pelletToDelete)
                {
                    current = current.Next;
                }
                current.Next = pelletToDelete.Next;

                //If you have just deleted the last node in the list
                if (pelletToDelete == tailPointer)
                {
                    //Set Tail to point to the “previous” node, because it is now at the end
                    tailPointer = current;
                }
            }
        }

        //==============================================================================
        // Walk the list, deleting all nodes whose IsAlive propoerty is false
        //==============================================================================
        public void DeleteNotAlive()
        {
            Pellet current = headPointer;
            while (current != null)
            {
                if(current.IsAlive == false)
                {
                    DeleteOne(current);
                }    
                current = current.Next;
            }
        }

        //==============================================================================
        // Walk the list, calling each node's Draw method
        //==============================================================================
        public void Draw()
        {
            Pellet current = headPointer;
            while (current != null)
            {
                current.Draw();
                current = current.Next;
            }
        }
    }
}
