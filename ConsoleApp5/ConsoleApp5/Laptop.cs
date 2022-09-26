using hereVGA;
using hereProccesor;
class Laptop
{
    public string merk;
    public string tipe;
    public VGA Vga;
    public Proccesor proccesor;
    public void laptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");

    }
    public void laptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
 }
class Asus : Laptop
{
    public Asus()
    {
        merk = "ASUS";
    }
}
class ROG : Asus
{
    public ROG()
    {
        tipe = "ROG";

    }
}
class Vivobook : Asus
{
    public Vivobook()
    {
        tipe = "vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class Acer : Laptop
{
    public Acer()
    {
        merk = "ACER";

    }
}
class Swift : Acer
{
    public Swift()
    {
        tipe = "swift";

    }
}
class Predator : Acer
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}
class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}
class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}