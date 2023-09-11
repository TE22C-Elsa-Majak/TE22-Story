Console.WriteLine("Framför dig finns det två dörrar, en blå och en röd, vilken väljer du?");
string dörr = Console.ReadLine().ToLower();


if (dörr == "Blå" || dörr == "blå")
{
    Console.WriteLine("WASTED! - Du valde fel dörr och blev skjuten i huvudet...");
}
else if (dörr == "Röd" || dörr == "röd")
{
    Console.WriteLine("Du ser nu yttligare två dörrar framför dig, en gul och en svart, vilken väljer du?");
    dörr = Console.ReadLine();
    if (dörr == "Gul" || dörr == "gul")
    {
        Console.WriteLine("Du har kommit ut och överlevt!");
    }
    else if (dörr == "Svart" || dörr == "svart")
    {
        Console.WriteLine("WASTED! - Du valde fel dörr och gick in i lava...");
    }
}
Console.ReadLine();