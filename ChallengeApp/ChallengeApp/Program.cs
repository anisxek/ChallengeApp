var name = "Ewa";
var sex = "kobieta";
var age = 30;


if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa 30 lat");
}
else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("");
}