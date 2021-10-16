using System.ComponentModel.DataAnnotations;

namespace mari.diego._5h.PrimoEF
{
    public class Persona
    {
        [Key]
        public int PersonaID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}