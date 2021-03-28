namespace DuckSimulator
{
    public abstract class Duck
    {
        public Duck(string name, string color, int age)
        {
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
    }
}
