using System.Threading;
namespace pretpark.kaart
{
    class Pad
    {
        private float? lengteBerekend;

        public Coordinaat van;
        public Coordinaat naar;

        public Pad(Coordinaat van, Coordinaat naar)
        {
            this.van = van;
            this.naar = naar;
        }

        public float Lengte()
        {
            if(lengteBerekend != null) {
                return (float) lengteBerekend;
            } else {
                var xDiff = Math.Abs(van.x - naar.x);
                var yDiff = Math.Abs(van.y - naar.y);
                float res = (float) Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
                lengteBerekend = res;
                return res;
            }
        }

        public void setVan(Coordinaat van)
        {
            this.van = van;
            this.lengteBerekend = null;
        }

        public void setNaar(Coordinaat naar)
        {
            this.naar = naar;
            this.lengteBerekend = null;
        }

        public void TekenConsole(ConsoleTekener t) 
        {
            Coordinaat verschil = naar - van;
            ConsoleTekener.maxRow = Math.Max(ConsoleTekener.maxRow, Math.Max(van.y, naar.y));
            Boolean printed = false;
            for (int i = 0; i < Lengte(); i++) {
                Coordinaat newCoordinaat = van + new Coordinaat((int) (verschil.x * (float) i / Lengte()), (int) (verschil.y * (float) i / Lengte()));
                if((i > Lengte() / 2) && printed == false)
                {
                    string floatString = (this.Lengte() * 1000).metSuffixen();
                    ConsoleTekener.SchrijfOp(newCoordinaat, floatString);
                    printed = true;
                } else {
                    ConsoleTekener.SchrijfOp(newCoordinaat, "#");
                }
                
                //Thread.Sleep(5);
            }
            
        }
    }
}