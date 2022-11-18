using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuku
{
    public class Item
    {
        private int _Id;

        public int Id
        {
            get { return _Id; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Price { get; set; }

        //constaractor that must contain Id
        public Item(int numberId)
        {
            _Id = numberId;
        }

        public class RunItem
        {
            public void FrunItem()
            {
                //Arry defition, size = 2 , from type : Item;
                Item[] ArrItem2 = new Item[2];

                //insert to the first place a show of drink;
                Drink tapuz = new Drink(001, "orange");
                ArrItem2[0] = tapuz;

                //insert to the second place a show of food;
                Food tapuch = new Food(002,15);
                ArrItem2[1] = tapuch;
            }
           
            public void arrTen()
            {
                // created new arry [10]
                Item[] ArrItem10 = new Item[10];

                //creation of 5 shows of Drink;
                Drink anavim = new Drink(0001, "purple");
                Drink kola = new Drink(0002, "black");
                Drink rebar = new Drink(0003, "colorfull");
                Drink fuzeTea = new Drink(0004, "lightOrange");
                Drink water = new Drink(0005, "transparent");

                ArrItem10[0] = anavim;
                ArrItem10[1] = kola;
                ArrItem10[2] = rebar;
                ArrItem10[3] = fuzeTea;
                ArrItem10[4] = water;

                //creation of 5 shows of Food;
                Food shnizel = new Food(0006, 50);
                Food melawach = new Food(0007, 10);
                Food shawarma = new Food(0008, 70);
                Food havita = new Food(0009, 15);
                Food tost = new Food(0010, 5);

                ArrItem10[5] = shnizel;
                ArrItem10[6] = melawach;
                ArrItem10[7] = shawarma;
                ArrItem10[8] = havita;
                ArrItem10[9] = tost;

                anavim._Name = "anavim";
                kola._Name = "kola";
                rebar._Name = "rebar";
                fuzeTea._Name = "fuzeTea";
                water._Name = "water";
                shnizel._Name = "shnizel";
                melawach._Name = "melawach";
                shawarma._Name = "shawarma";
                havita._Name = "havita";
                tost._Name = "tost";

                for (int i = 0; i < 10; i++)
                { 
                    Console.WriteLine("ID:{0} Name:{1}", ArrItem10[i].Id, ArrItem10[i].Name);
                }

               
                // created new arry [100]
                Item[] ArrItem100 = new Item[100];

               Random rand = new Random(DateTime.Now.Millisecond); 

                for (int i = 0; i < 2; i++)
                {
                    //if 1 so true
                    if (rand.Next(1, 3) == 1)
                    {
                        Console.WriteLine("please enter drink id:");
                        int IdSheldrink = 0;
                        IdSheldrink = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter drink Name:");
                      string NameSheldrink = (Console.ReadLine());

                        Console.WriteLine("please enter drink color:");
                        string Drink_Color =Console.ReadLine();

                        Console.WriteLine("please enter drink Price:");
                        int PriceSheldrink = 0;
                        PriceSheldrink = Convert.ToInt32(Console.ReadLine());

                        //creation mofa shel drink
                        ArrItem100[i] = new Drink(IdSheldrink, Drink_Color);

                        ArrItem100[i].Name = NameSheldrink;
                        ArrItem100[i].Price= PriceSheldrink;    
                    }
                    else 
                    {
                        Console.WriteLine("please enter Food ID:");
                        int IdShelFood = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter Food Name:");
                        string NameShelfood = (Console.ReadLine());

                        Console.WriteLine("please enter Food Weight:");
                        int Food_Weight = 0;
                        Food_Weight = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter food Price:");
                        int PriceShelfood = 0;
                        PriceShelfood = Convert.ToInt32(Console.ReadLine());

                        //creation mofa shel food;
                        ArrItem100[i] = new Food(IdShelFood, Food_Weight);

                        ArrItem100[i].Name = NameShelfood;
                        ArrItem100[i].Price = PriceShelfood;
                    }
                }
                // printing all ID;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("THE ID in postion {0} is:", i);
                    Console.WriteLine("{0}",ArrItem100[i].Id);
                }

                // checking if item drink or food
                for (int i = 0; i < 2; i++)
                {
                    if (ArrItem100[i] is Food )
                    {
                        Food mazon = (Food)ArrItem100[i];

                        Console.WriteLine(" Food info is:");
                        Console.WriteLine("ID:{0} Name:{1} Weight:{2} Price:{3}", mazon.Id,mazon.Name, mazon.Weight,mazon.Price);
                    }
                    else if (ArrItem100[i] is Drink)
                    {
                         Drink mashke = (Drink)ArrItem100[i];

                        Console.WriteLine(" Drink info is:");
                        Console.WriteLine("ID:{0}  Name:{1}  Color:{2}  Price:{3}", mashke.Id, mashke.Name,mashke.LiquidColor,mashke.Price);
                    }

                }
                int stop = 141;
            }
        }
     
    }
}
