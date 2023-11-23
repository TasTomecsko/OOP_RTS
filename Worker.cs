
namespace OOP_RTS
{
    internal class Worker : People
    {
        private Occupations occupation;

        public Occupations Occupation { get { return occupation; } set { occupation = value; } }

        public Worker(int age, string name, Occupations occ) 
        {
            Age = age;
            Name = name;
            Occupation = occ;
        }

        public Worker(int age, Occupations occ) 
        {
            Age = age;
            Occupation = occ;
        }

        public void Work()
        {
            switch (occupation)
            {
                case Occupations.None:
                {
                    Console.WriteLine("Nothing to do");
                    break;
                }
                case Occupations.Miner:
                {
                    Console.WriteLine("Mining resources");
                    break;
                }
                case Occupations.Forager:
                {
                    Console.WriteLine("Collecting berries");
                    break;
                }
                case Occupations.Woodcutter:
                {
                    Console.WriteLine("Cutting wood");
                    break;
                }
            }
        }

    }
}
