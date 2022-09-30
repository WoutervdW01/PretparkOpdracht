namespace pretpark.kaart
{
    struct Coordinaat {
        public int x { get;}
        public int y { get;}

        public Coordinaat(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Coordinaat operator+ (Coordinaat A, Coordinaat B)
        {
            Coordinaat coordinaat = new Coordinaat(A.x + B.x, A.y + B.y);
            return coordinaat;
        }

        public static Coordinaat operator- (Coordinaat A, Coordinaat B)
        {
            Coordinaat coordinaat = new Coordinaat(A.x - B.x, A.y- B.y);
            return coordinaat;
        }
    }
}