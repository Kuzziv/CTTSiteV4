using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CTTSite.Models.Forms
{
    // Made by Christian
    public class FormActivityList 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string UserEmail { get; set; }

        public string Pleasure { get; set; }
        public string Exercise { get; set; }
        public string Achievement { get; set; }
        public string Social { get; set; }

        public FormActivityList()
        {
        }

        public FormActivityList(string user, string pleasure, string exercise, string achievement, string social)
        {
            UserEmail = user;
            Pleasure = pleasure;
            Exercise = exercise;
            Achievement = achievement;
            Social = social;
        }

        public override string ToString()
        {
            return $"Pleasure: {Pleasure}\nExercise: {Exercise}\nAchievement: {Achievement}\nSocial: {Social}";
        }
    }
}
