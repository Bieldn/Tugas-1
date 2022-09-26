using hereProccesor;
using hereVGA;
namespace programpbo
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            Laptop laptop2 = new IdeaPad();
            Predator predator = new Predator();
            laptop1.Vga = new Nvidia();
            laptop1.proccesor = new Corei5();
            laptop2.Vga = new AMD();
            laptop2.proccesor = new Rayzen();
            predator.Vga = new AMD();
            predator.proccesor = new Corei7();

            //laptop2.laptopDinyalakan();
            //laptop2.laptopDimatikan();

            //laptop1.Ngoding();
            //Console.WriteLine(laptop1.Vga.merk+laptop1.proccesor.merk+laptop1.proccesor.tipe);
            //predator.BermainGame();
            //Acer acer = new Predator();
            //acer.BermainGame();
        }

    }
}
