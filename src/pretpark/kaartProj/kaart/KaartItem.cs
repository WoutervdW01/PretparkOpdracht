namespace pretpark.kaart 
{
    abstract class KaartItem : Tekenbaar {
        private Coordinaat _locatie;
        private Kaart kaart;
        public abstract char Karakter { get;}

        //public abstract char Karakter();

        public KaartItem(Kaart kaart, Coordinaat _locatie)
        {
            this.setLocatie(_locatie);
            this.kaart = kaart;
        }

        public void TekenConsole(ConsoleTekener t)
        {
            ConsoleTekener.SchrijfOp(_locatie,  Karakter.ToString());
        }

        public Coordinaat getLocatie() 
        {
            return this._locatie;
        }

        /*  Setter for the location checks if the 'Coordinaat' has negative values.
        *   If so, it throws an exception to tell the user that negative values are not allowed
        */  
        public void setLocatie(Coordinaat c)
        {
            if(c.x < 0 || c.y < 0)
            {
                throw new Exception("Locatie kan geen negatieve coordinaten bevatten!");
            }
            else 
            {
                this._locatie = c;
            }
        }
    }
}