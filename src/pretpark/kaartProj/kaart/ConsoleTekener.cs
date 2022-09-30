namespace pretpark.kaart
{

    interface Tekener {
        void ITeken(Tekenbaar t);
    }

    class ConsoleTekener : Tekener{
        public static int OrigRow {get; set;}
        public static int OrigCol {get; set;}
        public static int maxRow {get; set;}

        public void ITeken(Tekenbaar t) {
            Console.WriteLine("Implemented World");            
        }

        public static void SchrijfOp(Coordinaat Pos, string Text)
        {
            if(Pos.x < 0 || Pos.y < 0)
            {
                throw new Exception("Kan niet tekenen in het negatieve!");
            }
            //Console.WriteLine(String.Format("X coordinaat: {0}, Y coordinaat: {1}", Pos.x, Pos.y));
            try {
                Console.SetCursorPosition(OrigCol + Pos.x, OrigRow + Pos.y);
                Console.WriteLine(Text);
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}