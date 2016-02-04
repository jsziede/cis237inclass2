using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Hanoi
    {
        public void moveDisks(int n, char source, char auxiliary, char destination)
        {
            //base case to exit recursive loop
            if (n == 1)
            {
                //since we only have to move one disk. (n == 1), we don't want to make another recursive call, we just want to ouput the move that we are performing
                Console.WriteLine("Move disk from tower {0} to tower {1}", source, destination);
            }
            else
            {
                //attempt to move (n - 1) disks from the source location (A) to auxiliary (B), using the C peg as temp storage
                moveDisks(n - 1, source, destination, auxiliary);

                //move A to C
                moveDisks(1, source, auxiliary, destination);

                //move (n - 1) from B C using the beginning as temp storage
                moveDisks(n - 1, auxiliary, source, destination);
            }
        }
    }
}
