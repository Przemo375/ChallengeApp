

using ChallengeApp;

Employee user1 = new Employee("Adam", "Kowalski", 24);
Employee user2 = new Employee("Monika", "Mak", 30);
Employee user3 = new Employee("Błażej", "Jeziorski",18);

user1.AddScore(5);                             
user1.AddScore(2);
user1.AddScore(1);
user1.AddScore(3);
user1.AddScore(6);

user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(9);
user2.AddScore(9);
user2.AddScore(2);                       

user3.AddScore(6);
user3.AddScore(1);
user3.AddScore(1);
user3.AddScore(2);
user3.AddScore(5);


List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int maxResult = -1;
Employee userWithMaxResult = null;

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
    }
}

Console.WriteLine("Osoba z najwyższą punktacją" + userWithMaxResult.Name + "" + userWithMaxResult.Surename + "wiek:" + userWithMaxResult.Age + "punkty:" + userWithMaxResult.Result);