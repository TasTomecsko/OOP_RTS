namespace OOP_RTS
{
    internal class Program
    {
        static void Main()
        {
            List<Worker> workers = new List<Worker>(); // Initializing the Worker list

            // Arrays of names and ages
            string[] names = { "Alexa", "Steve", "Thomas", "Linda" };
            int[] ages = { 22, 25, 20, 19 };

            List<Occupations> occupations = new List<Occupations>();
            foreach (Occupations occ in Enum.GetValues(typeof(Occupations))) {
                occupations.Add(occ); // Listing all the posible values from the occupations enum
            }

            int temp = 0; // To avoid running out of occupations (later try random number generation)

            for (int i = 0; i < names.Length; i++)
            {
                workers.Add(new Worker(ages[i], names[i], occupations[temp])); // Creatig workers

                if (temp >= occupations.Count)
                    temp = 0;
                else
                    temp++;
            }
        }
    }
}