namespace DataInventoryManagement1
{
    class Program
    {


        public static void Main(string[] args)
        {
         string Path = 
         FetchJsonForRice fetchJsonforRice = new FetchJsonForRice();
         fetchJsonForRice.Read(Path)
      
                Rice data = FetchJsonForRice.Read(Path);
             for ( int i =0; i < data.typesOfRice.Count; i++)
            {
                Console.WriteLine(data.typesOfRice[i].name);
                Console.WriteLine(data.typesOfRice[i].weight);
                Console.WriteLine(data.typesOfRice[i].price);
                Console.WriteLine("_______________________________________");
            
          }
            for (int i = 0; i < data.typesOfPulses.Count; i++)
            {
                Console.WriteLine(data.typesOfPulses[i].name);
                Console.WriteLine(data.typesOfPulses[i].weight);
                Console.WriteLine(data.typesOfPulses[i].price);
                Console.WriteLine("_______________________________________");

            }

            for (int i = 0; i < data.typesOfWheat.Count; i++)
            {
                Console.WriteLine(data.typesOfWheat[i].name);
                Console.WriteLine(data.typesOfWheat[i].weight);
                Console.WriteLine(data.typesOfWheat[i].price);
                Console.WriteLine("_______________________________________");

            }
            //    DeckCards.DeckOfCards();

            // PlayerDeckOfCards.DeckOfCards();


            //  CompanyShares.ListOfCompanyShares();




        }
    }
}

