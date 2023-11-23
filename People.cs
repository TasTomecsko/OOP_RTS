
namespace OOP_RTS
{
    internal class People // People base class
    {
        // Variables associated with this class
        private int age;
        private string? name;

        // Getter and setter
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name 
        { 
            get { return name == null ? "Anonymus" : name; } // If no name is given the default name is Anonymus
            set { name = value; } 
        }
    }
}
