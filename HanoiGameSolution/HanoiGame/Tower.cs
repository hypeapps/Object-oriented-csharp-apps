using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    public class Tower<T> : IPrintable 
        where
        T: Disk
    {
        public int Height { get; set; }
        public int TowerHeight { get; set; }
        public List<T> TowerList { get; set; } 

        public Tower(int towerHeight)
        {
            this.TowerHeight = towerHeight;
            this.TowerList = new List<T>();
            this.Height = 0;
        }

        public void Push(T disk)
        {
            if (this.Height == 0)
            {
                this.TowerList.Add(disk);
                this.Height++;
            }
            else
            {
                if (disk.CompareTo(TowerList[TowerList.Count - 1]))
                {
                    this.TowerList.Add(disk);
                    this.Height++;
                }
                else
                {
                    Exception largerOnSmallerElementException = new LargerOnSmallerElementException("Próbujesz położyć większy dysk na mniejszy!");
                    throw largerOnSmallerElementException;
                }
            }
            

        }

        public Disk Pop()
        {
            Disk tempDisk;
            if (TowerList.Count == 0)
            {
                Exception emptyTowerException = new EmptyTowerException("Próbujesz zdjąc dysk z pustej wieży!");
                throw emptyTowerException;
            }
            else 
            {
                tempDisk = TowerList[TowerList.Count - 1];
                this.TowerList.RemoveAt(TowerList.Count - 1);
                this.Height--;
                return tempDisk;
            }
        }

        public void Print()
        {
            //ELEMENT PUSTY WIEZY

            for (int i = 0; i <= this.TowerHeight - TowerList.Count - 1; i++)
            {
                for (int x = 0; x < TowerHeight; x++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("[]");
            }


            //WRITE DYSKI

            for (int i = 0; i <= TowerList.Count - 1; i++)
            {
                for (int x = 0; x < TowerHeight - TowerList[TowerList.Count - i - 1].DiskSize; x++)
                {
                    Console.Write(" ");
                }
                TowerList[TowerList.Count - i - 1].Print();
            }
        }
    }
}
