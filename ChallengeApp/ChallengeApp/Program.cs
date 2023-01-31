// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Cześć, to ja Robert. Pozdrawiam Was serdecznie z Trójmiasta");
string name = "Ewa";
char gender = 'f'; // niby mogłoby być bool, ale w dzisiejszych czasach stosuje się m/f/d 
int age = 33;

if (gender == 'f' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == 'm' && age < 18)
{
    Console.WriteLine("Nieletni Mężczyzna");
}
else
{
    Console.WriteLine("Jakaś inna Istota");
}