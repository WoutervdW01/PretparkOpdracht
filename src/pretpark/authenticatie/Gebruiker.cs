using System;
namespace pretpark.authenticatie
{
    public class Gebruiker
    {
        public String Wachtwoord {get; set;}
        public String Email {get; set;}
        public VerificatieToken? verificatieToken{get; set;}

        public Boolean Geverifieerd()
        {
            return verificatieToken == null;
        }

        public Gebruiker(string Email, string Wachtwoord)
        {
            Random rnd = new Random();
            string token = "" + rnd.Next(1000, 9999);
            this.Email = Email;
            this.Wachtwoord = Wachtwoord;
            this.verificatieToken = new VerificatieToken(token, DateTime.Now.AddDays(3));
        }
    }
}