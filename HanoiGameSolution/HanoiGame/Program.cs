using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Program
    {
        static Disk transferDisk;

        static void Main(string[] args)
        {
            int diskCount = 0;
            Disk[] disks;

            label1:
            Console.WriteLine("Podaj ilośc dysków");
            try
            {
                diskCount = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("To nie liczba. WCISNIJ ENTER.");
                Console.ReadKey();
                Console.Clear();
                goto label1;
            }

            Console.Clear();

            Tower<Disk> towerA = new Tower<Disk>(diskCount);
            Tower<Disk> towerB = new Tower<Disk>(diskCount);
            Tower<Disk> towerC = new Tower<Disk>(diskCount);
            disks = new Disk[diskCount];

            for (int i = 0; i <= diskCount - 1; i++)
            {
                disks[i] = new Disk(i + 1, diskCount);
            }


            for (int i = diskCount - 1; i >= 0; i--)
            {
                towerA.Push(disks[i]);
            }

            int towerChoose = 0;
            int towerDest = 0;
            
            do
            {
            label:
                towerA.Print();
                Console.WriteLine("WIEŻA NR 1\n");
                towerB.Print();
                Console.WriteLine("WIEŻA NR 2\n");
                towerC.Print();
                Console.WriteLine("WIEŻA NR 3\n");

                Console.WriteLine("Podaj numer wieży z której chcesz przełożyć dysk [1, 2, 3]");

                try
                {
                    towerChoose = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Błąd: to nie numer. WCISNIJ ENTER");
                    Console.ReadKey();
                    Console.Clear();
                    goto label;
                }

                if (towerChoose > 0 && towerChoose <= 3)
                {
                    Console.WriteLine("Podaj numer wieży docelowej [1, 2, 3,]");
                    
                    try
                    {
                        towerDest = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Błąd: to nie numer. WCISNIJ ENTER");
                        Console.ReadKey();
                        Console.Clear();
                        goto label;
                    }

                    if (towerDest > 0 && towerDest <= 3)
                    {
                        try
                        {
                            switch (towerChoose)
                            {
                                case 1:
                                    transferDisk = towerA.Pop();
                                    break;
                                case 2:
                                    transferDisk = towerB.Pop();
                                    break;
                                case 3:
                                    transferDisk = towerC.Pop();
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + " WCISNIJ ENTER ");
                            Console.ReadKey();
                            Console.Clear();
                            goto label;

                        }


                        try
                        {
                            switch (towerDest)
                            {
                                case 1:
                                    towerA.Push(transferDisk);
                                    break;
                                case 2:
                                    towerB.Push(transferDisk);
                                    break;
                                case 3:
                                    towerC.Push(transferDisk);
                                    break;
                            }
                        }
                        catch (Exception ex)
                        {
                            switch (towerChoose)
                            {
                                case 1:
                                    towerA.Push(transferDisk);
                                    break;
                                case 2:
                                    towerB.Push(transferDisk);
                                    break;
                                case 3:
                                    towerC.Push(transferDisk);
                                    break;
                            }
                            Console.WriteLine(ex.Message  + " WCISNIJ ENTER ");
                            Console.ReadKey();
                            Console.Clear();
                            goto label;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Zły numer wieży docelowej. Wcisnij ENTER by grac dalej");
                        Console.ReadKey();
                    }
                }

                else
                {
                    Console.WriteLine("Zły numer wieży. Wcisnij ENTER by grac dalej");
                    Console.ReadKey();
                }

                Console.Clear();
            } while (towerC.Height < diskCount);

            Console.WriteLine("Gratulacje! Udało Ci się przełożyć odpowiednio dyski!");
            Console.ReadKey();
              
         
        }
    }
}
