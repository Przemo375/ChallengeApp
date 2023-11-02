var name = "Ewa";
var gender = "Kobieta";
var age = 40;


 if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (gender == "Kobieta" && age > 30)
{
    Console.WriteLine("Kobieta powyżej 30lat");
}
else if (gender == "Męszczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Męszczyzna");
} 