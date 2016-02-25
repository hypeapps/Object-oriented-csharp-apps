using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    public class Disk : IPrintable, ICompareTo
    {
        public int DiskSize { get; set; }


        public Disk(int diskSize, int towerHeight)
        {
            this.DiskSize = diskSize;
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < DiskSize ; i++)
            {
                Console.Write("__");
            }
            Console.Write("]");
            Console.WriteLine("");
        }

        public bool CompareTo(Disk diskToCompare)
        {
            if (this.DiskSize < diskToCompare.DiskSize)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
