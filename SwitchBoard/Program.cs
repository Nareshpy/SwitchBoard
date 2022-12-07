using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var appliances = new Dictionary<string, string>();
                Console.WriteLine("Enter number of Fans");
                int fansNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Console.WriteLine("Enter number of ACs");
                int acsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Console.WriteLine("Enter number of Bulbs");
                int bulbsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                void mainMenu()
                {
                    Console.WriteLine("Select the item by entering its name;for example fan1,ac2,bulb3...");
                    Console.WriteLine("__________________________________________________________________________");
                    int i = 0;
                    while (i < fansNeeded && i < acsNeeded && i < bulbsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + " ->" + appliances[$"fan{i + 1}"] + "\t" + $"ac{i + 1}" + " ->" + appliances[$"ac{i + 1}"] + "\t" + $"bulb{i + 1}" + " ->" + appliances[$"bulb{i + 1}"]);
                        i++;
                    }
                    while (i < fansNeeded && i < acsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + " ->" + appliances[$"fan{i + 1}"] + "\t" + $"ac{i + 1}" + " ->" + appliances[$"ac{i + 1}"]);
                        i++;
                    }
                    while (i < fansNeeded && i < bulbsNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + " ->" + appliances[$"fan{i + 1}"] + "\t" + "\t" + " " + "\t" + $"bulb{i + 1}" + " ->" + appliances[$"bulb{i + 1}"]);
                        i++;
                    }
                    while (i < acsNeeded && i < bulbsNeeded)
                    {
                        Console.WriteLine("\t" + " " + " " + "\t" + $"ac{i + 1}" + " ->" + appliances[$"ac{i + 1}"] + "\t" + $"bulb{i + 1}" + " ->" + appliances[$"bulb{i + 1}"]);
                        i++;
                    }
                    while (i < fansNeeded)
                    {
                        Console.WriteLine($"fan{i + 1}" + "->" + appliances[$"fan{i + 1}"]);
                        i++;
                    }
                    while (i < acsNeeded)
                    {
                        Console.WriteLine("\t\t" + $"ac{i + 1}" + "->" + appliances[$"ac{i + 1}"]);
                        i++;
                    }
                    while (i < bulbsNeeded)
                    {
                        Console.WriteLine("\t" + "\t" + "\t" + "\t" + $"bulb{i + 1}" + " ->" + appliances[$"bulb{i + 1}"]);
                        i++;
                    }

                    Console.WriteLine("__________________________________________________________________________");
                }
                void subMenu(string selectedItem)
                {
                    Console.WriteLine("Select among the two options by entering their index");
                    if (appliances[selectedItem] == "off")
                    {
                        Console.WriteLine($"1.Switch {selectedItem} on");
                    }
                    else
                    {
                        Console.WriteLine($"1.Switch {selectedItem} off");
                    }
                    Console.WriteLine("2.Go Back");
                    int optionEntered = (int)Convert.ToInt64((Console.ReadLine()));
                    if(optionEntered==1)
                    {
                        if (appliances[selectedItem] == "off")
                        {
                            appliances[selectedItem] = "on";
                        }
                        else
                        {
                            appliances[selectedItem] = "off";
                        }

                    }
                }
                for (int i = 0; i < fansNeeded; i++)
                {
                    string v = "fan" + $"{i+1}";
                    appliances[v] = "off";   
                }
                for (int i = 0; i < acsNeeded; i++)
                {
                    string v = "ac" + $"{i + 1}";
                    appliances[v] = "off";
                }
                for (int i = 0; i < bulbsNeeded; i++)
                {
                    string v = "bulb" + $"{i + 1}";
                    appliances[v] = "off";
                }
                while (true)
                {

                    mainMenu();
                    string item=Console.ReadLine();
                    item=item.ToLower();
                    if (appliances.ContainsKey(item))
                    {
                        subMenu(item);
                    }
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
