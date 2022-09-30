namespace pretpark.authenticatie
{
    public class VerificatieToken
    {
        public String token { get; set;}
        public DateTime verloopDatum {get; set;}

        public VerificatieToken(String token, DateTime verloopdatum)
        {
            this.token = token;
            this.verloopDatum = verloopDatum;
        }
    }
}