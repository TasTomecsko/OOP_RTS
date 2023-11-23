
namespace OOP_RTS
{
    internal class People
    {
        private int age;
        private string? name;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name 
        { 
            get { return name == null ? "Anonymus" : name; } 
            set { name = value; } 
        }
    }
}
