
namespace OOP_RTS
{
    internal class Worker : People
    {
        // Occupation enum can be given to the worker class.
        private Occupations occupation;

        // Constructor
        public Occupations Occupation { get { return occupation; } set { occupation = value; } }

        public Worker(int age, string name, Occupations occ) // Constructor with all possible arguments
        {
            Age = age;
            Name = name;
            Occupation = occ;
        }

        public Worker(int age, Occupations occ) // Constructor with only age and occupation arguments
        {
            Age = age;
            Occupation = occ;
        }

        public void Work() // Different feedback regarding the Workers occupation
        {
            switch (occupation)
            {
                case Occupations.None:
                {
                    Console.WriteLine(Name + " has nothing to do!");
                    break;
                }
                case Occupations.Miner:
                {
                    Console.WriteLine(Name + " is mining resources!");
                    break;
                }
                case Occupations.Forager:
                {
                    Console.WriteLine(Name + " is collecting berries!");
                    break;
                }
                case Occupations.Woodcutter:
                {
                    Console.WriteLine(Name + " is cutting wood!");
                    break;
                }
            }
        }

    }
}
