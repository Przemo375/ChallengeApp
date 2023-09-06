namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; set; }

        public string Surename { get; set; }

        public int Age { get; set; }

        private List<int> score = new List<int>();

        public Employee(string name, string surename, int age)
        {
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
        }


        public int Result
        {
            get
            {
                return this.score.Sum();
            }


        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}
