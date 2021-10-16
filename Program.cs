using System;

namespace mari.diego._5h.PrimoEF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apro il db
            DbPersone db = new();

            // Aggiungo una nuova persona
            for(int i = 0; i < 1000; i++)
            {
                db.Persone.Add(new Persona 
                { 
                    Nome = "Diego", 
                    Cognome = "Mari", 
                    Email = "diego.mari@studenti.ittsrimini.edu.it"
                });
            }

            db.SaveChanges();
        }
    }
}
