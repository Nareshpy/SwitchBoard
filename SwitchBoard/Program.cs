using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard
{
     public class Parent
    {
        public bool switchkey = false;
    }
     public class Fan : Parent 
    {
        static int fanCount = 0;
       public Fan()
        { fanCount++; }

    }
    public class Acs : Parent 
    {
        static int acsCount = 0;
       public Acs()
        { acsCount++; }

    }
     public class Bulbs : Parent 
    {
        static int bulbsCount = 0;
       public Bulbs()
        { bulbsCount++; }

    }


    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number of Fans");
                int fansNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Fan[] fanArray = new Fan[fansNeeded];
                Console.WriteLine("Enter number of ACs");
                int acsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Acs[] acsArray = new Acs[acsNeeded];
                Console.WriteLine("Enter number of Bulbs");
                int bulbsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Bulbs[] bulbsArray = new Bulbs[bulbsNeeded];
                void mainMenu()
                {
                    Console.WriteLine("Select the item by entering its name;for example fan1,ac2,bulb3...");
                    Console.WriteLine("__________________________________________________________________________");
                    //for (int i = 0; i < fansNeeded; i++)
                    //{
                    //    Console.WriteLine($"{i + 1}.fan{i + 1}" + "  " + fanArray[i].switchkey);
                    //}
                    //for (int i = 0; i < acsNeeded; i++)
                    //{
                    //    Console.WriteLine($"{i + 1 + fansNeeded}.ac{i + 1}" + "  " + acsArray[i].switchkey);
                    //}
                    //for (int i = 0; i < bulbsNeeded; i++)
                    //{
                    //    Console.WriteLine($"{i + 1 + fansNeeded + acsNeeded}.bulb{i + 1}" + "  " + bulbsArray[i].switchkey);
                    //}
                    int i = 0;
                    while(i<fansNeeded && i< acsNeeded && i< bulbsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}"+" ->"+ fanArray[i].switchkey + "\t" + $"ac{i + 1}" + " ->" + acsArray[i].switchkey+ "\t" + $"bulb{i + 1}" +" ->"+ bulbsArray[i].switchkey);
                        i++;
                    }
                    while (i < fansNeeded && i < acsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + " ->" + fanArray[i].switchkey + "\t" + $"ac{i + 1}" + " ->" + acsArray[i].switchkey );
                        i++;
                    }
                    while (i < fansNeeded  && i < bulbsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + " ->" + fanArray[i].switchkey + "\t" + "\t" + " " + "\t" + $"bulb{i + 1}" + " ->" + bulbsArray[i].switchkey);
                        i++;
                    }
                    while (i <acsNeeded && i < bulbsNeeded)
                    {
                        Console.WriteLine("\t" + " " + " " + "\t" + $"ac{i + 1}" + " ->" + acsArray[i].switchkey + "\t" + $"bulb{i + 1}" + " ->" + bulbsArray[i].switchkey);
                        i++;
                    }
                    while (i < fansNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + "->" + fanArray[i].switchkey);
                        i++;
                    }
                    while (i < acsNeeded)
                    {
                        Console.WriteLine("\t\t"+$"ac{i + 1}" + "->" +acsArray[i].switchkey);
                        i++;
                    }
                    while (i < bulbsNeeded)
                    {
                        Console.WriteLine("\t"+"\t"+"\t"+"\t"+$"bulb{i + 1}" + " ->" + bulbsArray[i].switchkey);
                        i++;
                    }
                    Console.WriteLine("__________________________________________________________________________");
                }
                void subMenu(int i, int j)
                {
                    Console.WriteLine("Select among the two options by entering their index");

                    if (j == 0)
                    {
                        if (fanArray[i].switchkey)
                        {
                            Console.WriteLine($"1.Switch fan{i + 1} off");

                        }
                        else
                        {
                            Console.WriteLine($"1.Switch fan{i + 1} on");

                        }
                        Console.WriteLine($"2.Go Back");
                        int optionEntered = (int)Convert.ToInt64((Console.ReadLine()));
                        if (optionEntered == 1)
                        {
                            if (fanArray[i].switchkey)
                            {
                                fanArray[i].switchkey = false;
                            }
                            else 
                            {
                                fanArray[i].switchkey = true;
                            }
                        }
                    }
                    else if (j == 1)
                    {
                        if (acsArray[i].switchkey)
                        {
                            Console.WriteLine($"1.Switch AC{i + 1} off");

                        }
                        else
                        {
                            Console.WriteLine($"1.Switch AC{i + 1} on");

                        }
                        Console.WriteLine($"2.Go Back");
                        int optionEntered = (int)Convert.ToInt64((Console.ReadLine()));
                        if (optionEntered == 1)
                        {
                            if (acsArray[i].switchkey)
                            {
                                acsArray[i].switchkey = false;
                            }
                            else
                            {
                                acsArray[i].switchkey = true;
                            }
                        }

                    }
                    else
                    {
                        if (bulbsArray[i].switchkey)
                        {
                            Console.WriteLine($"1.Switch bulb{i + 1} off");

                        }
                        else
                        {
                            Console.WriteLine($"1.Switch bulb{i + 1} on");

                        }
                        Console.WriteLine($"2.Go Back");
                        int optionEntered = (int)Convert.ToInt64((Console.ReadLine()));
                        if (optionEntered == 1)
                        {
                            if (bulbsArray[i].switchkey)
                            {
                                bulbsArray[i].switchkey = false;
                            }
                            else
                            {
                                bulbsArray[i].switchkey = true;
                            }
                        }

                    }

                }
                Console.WriteLine("extra-line");
                for (int i = 0; i < fansNeeded; i++)
                {
                    Fan obj = new Fan();
                    fanArray[i] = obj;
                }
                for (int i = 0; i < acsNeeded; i++)
                {
                    Acs obj = new Acs();
                    acsArray[i] = obj;
                }
                for (int i = 0; i < bulbsNeeded; i++)
                {
                    Bulbs ob = new Bulbs();
                    bulbsArray[i] = ob;
                }
                while (true)
                {
                    mainMenu();
                    //int itemRequired = (int)Convert.ToInt64((Console.ReadLine()));
                    string item=Console.ReadLine();
                    item=item.ToLower();
                    if (item.StartsWith("f"))
                    {
                        int x = int.Parse(item.Substring(3));
                        if (x > fansNeeded || x<=0)
                        {
                            Console.WriteLine("Item is not in the list\n");
                        }
                        else { subMenu(x - 1, 0); }  
                    }
                    else if (item.StartsWith("a"))
                    {
                        int x = int.Parse(item.Substring(2));
                        //subMenu(x - 1, 1);
                        if (x > acsNeeded || x<=0)
                        {
                            Console.WriteLine("Item is not in the list\n");
                        }
                        else { subMenu(x - 1, 1); }
                    }
                    else if (item.StartsWith("b"))
                    {
                        int x = int.Parse(item.Substring(4));
                        //subMenu(x - 1, 2);
                        if (x > bulbsNeeded || x<=0)
                        {
                            Console.WriteLine("Item is not in the list\n");
                        }
                        else { subMenu(x - 1, 2); }

                    }
                    //if (itemRequired <= fansNeeded)
                    //{
                    //    subMenu(itemRequired - 1, 0);
                    //}
                    //else if (itemRequired > fansNeeded && itemRequired <= fansNeeded + acsNeeded)
                    //{
                    //    subMenu(itemRequired - 1 - fansNeeded, 1);
                    //}
                    //else if (itemRequired > fansNeeded + acsNeeded && itemRequired <= fansNeeded + acsNeeded + bulbsNeeded)
                    //{
                    //    subMenu(itemRequired - 1 - fansNeeded - acsNeeded, 2);
                    //}
                    else
                    {
                        Console.WriteLine("Enter valid option");
                    }
                }
            }
            catch(FormatException )
            {
                Console.WriteLine("Re-run and please enter valid input i.e; prompted data types");
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadLine(); 
        }
       
           
    }
}
