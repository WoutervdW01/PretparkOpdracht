using System.Threading;

namespace pretpark.kaart
{
    class Starter 
    {
        private static ConsoleTekener? consoleTekener;
        private static Kaart? kaart;

        public static void Main(string[] args)
        {

            // TEST ONZIN \\
            consoleTekener = new ConsoleTekener();
            kaart = new Kaart(40, 40);

            Console.WriteLine(kaart.Hoogte);


            Console.WriteLine(1200f.metSuffixen());
            Console.WriteLine(2300000f.metSuffixen());
            Console.WriteLine(4600000000f.metSuffixen());

            

            Pad pad = new Pad(new Coordinaat(2, 5), new Coordinaat(12, 30));
            Pad pad1 = new Pad(new Coordinaat(26, 4), new Coordinaat(12, 5));
            Pad pad2 = new Pad(new Coordinaat(40, 40), new Coordinaat(10, 10));

            kaart.VoegPadToe(pad);
            kaart.VoegPadToe(pad1);
            kaart.VoegPadToe(pad2);

            try {
                Attractie attractie = new Attractie(kaart, new Coordinaat( 25, 25), 10, 5,"Kikkerbaan");
                Attractie attractie1 = new Attractie(kaart, new Coordinaat( 15, 25), 10, 5,"Kikkerbaan1");
                Attractie attractie2 = new Attractie(kaart, new Coordinaat( 30, 5), 10, 5,"Kikkerbaan2");

                kaart.VoegItemToe(attractie);
                kaart.VoegItemToe(attractie1);
                kaart.VoegItemToe(attractie2);
            } catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            kaart.TekenConsole(consoleTekener);
            Console.SetCursorPosition(0, ConsoleTekener.maxRow + ConsoleTekener.OrigRow);
        }
    }
}
