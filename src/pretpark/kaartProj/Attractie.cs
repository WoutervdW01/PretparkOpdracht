namespace pretpark
{
    class Attractie : kaart.KaartItem
    {
        private int? minLengte{get; set;}
        private int angstLevel{get; set;}
        private string naam{get; set;}
        public override char Karakter{get{
            return 'O';
        }}

        public Attractie(kaart.Kaart kaart, kaart.Coordinaat _locatie, int minLengte, int angstLevel, string naam): base(kaart, _locatie)
        {
            this.minLengte = minLengte;
            this.angstLevel = angstLevel;
            this.naam = naam;
        }

        
        
        
    }
}