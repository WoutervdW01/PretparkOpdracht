using System;

namespace pretpark.kaart
{
    class Kaart
    {
        public int Breedte {get; }
        public int Hoogte {get; }

        private List<Pad> paden = new List<Pad>();
        private List<KaartItem> items = new List<KaartItem>();

        public Kaart(int Breedte, int Hoogte)
        {
            this.Breedte = Breedte;
            this.Hoogte = Hoogte;
        }

        public void TekenConsole(ConsoleTekener t){
            //TODO
            //Console.Clear();
            ConsoleTekener.OrigCol = Console.CursorLeft;
            ConsoleTekener.OrigRow = Console.CursorTop;
            foreach (KaartItem item in items)
            {
                item.TekenConsole(t);
            }
            foreach (Pad p in paden)
            {
                p.TekenConsole(t);
            }
        }

        public void VoegItemToe(KaartItem item) {
            items.Add(item);
        }

        public void VoegPadToe(Pad pad) {
            paden.Add(pad);
        }
    }
}