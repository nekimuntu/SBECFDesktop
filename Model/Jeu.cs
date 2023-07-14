using System;

namespace SuperBowlWebDesktop.Model
{
    public class Jeu
    {
        public int Id { get; set; }

        public int EquipeAId { get; set; }
        public Equipe EquipeA { get; set; }

        public int EquipeBId { get; set; }
        public Equipe EquipeB { get; set; }
        public string Meteo { get; set; }

       
        public DateTime? DateRencontre { get; set; }
      
        public TimeSpan? HeureDebut { get; set; }
        
        public TimeSpan? HeureFin { get; set; }

        
        public int? ScoreEquipeA { get; set; }
        
        public int? ScoreEquipeB { get; set; }

        public int? EquipeGagnante { get; set; }

        public string Commentaires { get; set; }
        public string Status { get; set; }
        public short StatusCode { get; set; }
    }
}
