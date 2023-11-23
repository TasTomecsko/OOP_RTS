
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

        public People() {}

        public People(int age)
        {
            this.age = age;
        }

        public People(string name)
        {
            this.name = name;
        }

        public People(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
