using System;
using System.Collections.Generic;


namespace SwitchBoard
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           
            try
            {
                const string f = "fan", a = "ac", b = "bulb";
                var appliances = new Dictionary<string, bool>();
                Console.WriteLine("Enter number of Fans");
                int fansNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Console.WriteLine("Enter number of ACs");
                int acsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                Console.WriteLine("Enter number of Bulbs");
                int bulbsNeeded = (int)Convert.ToInt64((Console.ReadLine()));
                fillDictionary(fansNeeded, acsNeeded, bulbsNeeded);
                void mainMenu()
                {
                    Console.WriteLine("Select the item by entering its name;for example fan1,ac2,bulb3...");
                    Console.WriteLine("__________________________________________________________________________");
                    string fanState, bulbState, acState;
                    int i = 0;
                    while (i < fansNeeded && i < acsNeeded && i < bulbsNeeded)
                    {
                        fanState = appliances[$"{f}{i + 1}"] ? "on" : "off";
                        acState = appliances[$"{a}{i + 1}"] ? "on" : "off";
                        bulbState = appliances[$"{b}{i + 1}"] ? "on" : "off";
                        Console.WriteLine($"{f}{i + 1}" + " ->" + fanState + "\t" + $"{a}{i + 1}" + " ->" + acState + "\t" + $"{b}{i + 1}" + " ->" + bulbState);
                        i++;
                    }
                    while (i < fansNeeded && i < acsNeeded)
                    {
                        fanState= appliances[$"{f}{i + 1}"] ? "on" : "off";
                        acState= appliances[$"{a}{i + 1}"] ? "on" : "off";
                        Console.WriteLine($"{f}{i + 1}" + " ->" + fanState + "\t" + $"{a}{i + 1}" + " ->" + acState);
                        i++;
                    }
                    while (i < fansNeeded && i < bulbsNeeded)
                    {
                        fanState = appliances[$"{f}{i + 1}"] ? "on" : "off";
                        bulbState = appliances[$"{b}{i + 1}"] ? "on" : "off";
                        Console.WriteLine($"{f}{i + 1}" + " ->" + fanState + "\t" + "\t" + " " + "\t" + $"{b}{i + 1}" + " ->" + bulbState);
                        i++;
                    }
                    while (i < acsNeeded && i < bulbsNeeded)
                    {
                        bulbState = appliances[$"{b}{i + 1}"] ? "on" : "off";
                        acState = appliances[$"{a}{i + 1}"] ? "on" : "off";
                        Console.WriteLine("\t" + " " + " " + "\t" + $"{a}{i + 1}" + " ->" + acState + "\t" + $"{b}{i + 1}" + " ->" + bulbState);
                        i++;
                    }
                    while (i < fansNeeded)
                    {
                        fanState = appliances[$"{f}{i + 1}"] ? "on" : "off";
                        Console.WriteLine($"{f}{i + 1}" + "->" + fanState);
                        i++;
                    }
                    while (i < acsNeeded)
                    {
                      
                        acState = appliances[$"{a}{i + 1}"] ? "on" : "off";
                        Console.WriteLine("\t\t" + $"{a}{i + 1}" + "->" + acState);
                        i++;
                    }
                    while (i < bulbsNeeded)
                    {
                        
                        bulbState = appliances[$"{b}{i + 1}"] ? "on" : "off";
                        Console.WriteLine("\t" + "\t" + "\t" + "\t" + $"{b}{i + 1}" + " ->" + bulbState);
                        i++;
                    }

                    Console.WriteLine("__________________________________________________________________________");
                }
                void subMenu(string selectedItem)
                {
                    Console.WriteLine("Select among the two options by entering their index");
                    if (!appliances[selectedItem])
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
                        if (appliances[selectedItem])
                        {
                            appliances[selectedItem] = false;
                        }
                        else
                        {
                            appliances[selectedItem] = true;
                        }
                    }
                }
                void fillDictionary(int fansNeed,int acsNeed,int bulbsNeed)
                {
                    for (int i = 0; i < fansNeed; i++)
                    {
                        string v = $"{f}" + $"{i + 1}";
                        appliances[v] = false;
                    }
                    for (int i = 0; i < acsNeed; i++)
                    {
                        string v = $"{a}" + $"{i + 1}";
                        appliances[v] = false;
                    }
                    for (int i = 0; i < bulbsNeed; i++)
                    {
                        string v = $"{b}" + $"{i + 1}";
                        appliances[v] = false;
                    }
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
