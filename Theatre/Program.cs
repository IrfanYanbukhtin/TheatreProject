using Theatre.Models;
using Theatre.Services;

namespace Theatre
{
    internal class Program
    {
        public static Zal[] Zal1 { get; private set; }

        static void Main(string[] args)
        {
            var filmManager = new FilmManager();
            var seansManager = new SeansManager();
            var teatrManager = new TeatrManager();
            var ticketManager = new Ticketmanager();
            var zalManager = new ZalManager();

            string command = "";

            do
            {
                Console.Write("Enter the command:");
                command = Console.ReadLine();

                Zal[] Zal =
                {
                    new Zal
                    {
                        Id= 1,
                        Name = "Platinum",
                        Seats = new int [10,10]
                    },

                    new Zal
                    {
                        Id= 2,
                        Name = "Acces",
                        Seats = new int [10,10]
                    },

                    new Zal
                    {
                        Id= 3,
                        Name = "Silver",
                        Seats = new int [10,10]
                    }
                };

                Zal[] Zal2 =
                {
                    new Zal
                    {
                        Id= 1,
                        Name = " Gold",
                        Seats = new int [10,10]
                    },

                    new Zal
                    {
                        Id= 2,
                        Name = "Right",
                        Seats= new int [10,10]
                    },

                    new Zal
                    {
                        Id= 3,
                        Name = "Left",
                        Seats = new int [10,10]
                    }

                };

                if (command.ToLower().Equals("add cinema"))
                {
                    var teatr1 = new Teatr
                    {
                        Id = 1,
                        Name = "28 Mall",
                        Zals = Zal1,
                    };

                    var teatr2 = new Teatr
                    {
                        Id = 2,
                        Name = "Deniz Mall",
                        Zals = Zal2,
                    };

                    teatrManager.Add(teatr1);
                    teatrManager.Add(teatr2);
                }

                else if (command.ToLower().Equals("show cinema"))
                {
                    teatrManager.Print();
                }

                else if (command.ToLower().Equals("choose cinema"))
                {
                    Console.Write("Enter the Id:");
                    var id = int.Parse(Console.ReadLine());

                    var existTeatr = teatrManager.Get(id);
                    if (existTeatr == null)
                        continue;
                    Console.WriteLine(existTeatr);
                }

                else if (command.ToLower().Equals("add session"))
                {
                    var seans1 = new Seans
                    {
                        Id = 1,
                        Zal = new Zal
                        {
                            Id = 1,
                            Name = "Paltinum",

                        },
                        Film = new Film
                        {
                            Name = "Avatar",
                        },
                        StartTime = "15:00",
                        EndTime = "18:00",
                    };

                    var seans2 = new Seans
                    {
                        Id = 2,
                        Zal = new Zal
                        {
                            Id = 2,
                            Name = "Right"
                        },
                        Film = new Film
                        {
                            Name = " Sanctum"
                        },
                        StartTime = "19:00",
                        EndTime = "22:00" ,
                    };

                    seansManager.Add(seans1);
                    seansManager.Add(seans2);
                }
                else if (command.ToLower().Equals("show session"))
                {
                    seansManager.Print();
                }

                else if (command.ToLower().Equals("choose session"))
                {
                    Console.Write("Enter the ID:");
                    var id = int.Parse(Console.ReadLine());

                    var existSeans = seansManager.Get(id);
                    if (existSeans == null)
                        continue;

                    Console.WriteLine(existSeans);
                }

                else if (command.ToLower().Equals("show seats"))
                {
                    Zal zal = new();

                    zal.PrintSeats();
                }

            } while (command.ToLower() != "quit");


        }
    }
}