var name = "Przemek";
var age = 50;
var isWoman = false;

if (age >= 0)
{
    if (isWoman && age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat. Dodam jeszcze że ma na imię " + name);
    }
    else if (isWoman && name == "Ewa" && age == 33)
    {
        Console.WriteLine(name + ", lat " + age + ".");
    }
    else if (!isWoman && age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna. " + name + ", wiek: " + age + " lat.");
    }
    else if (name == "Przemek" && age == 50 && !isWoman)
    {
        Console.WriteLine("To jest " + name + "! " + age + " letni początkujący programista :D");
    }
    else Console.WriteLine("Nie mam zielonego pojęcia kim Ty jesteś :O");
}
else Console.WriteLine("Weź nie ściemniaj - nie można mieć " + age + " lat!");

