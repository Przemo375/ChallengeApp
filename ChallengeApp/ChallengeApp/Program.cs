using System.ComponentModel.Design;

var name = "Ewa";
int age = 33;
var gender = "Kobieta";


if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniźej 30 lat");
}
else if (name == "Ewa" && age == 30) 
{
    Console.WriteLine("Ewa, 30lat");
}
else if (gender != "Kobieta" && age < 18) 
{
    Console.WriteLine("Niepełnoletni męszczyzna");
}