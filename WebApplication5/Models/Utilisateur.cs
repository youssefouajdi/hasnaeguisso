using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Utilisateur
    {
        public int UtilisateurId { get; set; }
        public string UtilisateurName { get; set; }
        public int Age { get; set; }
        public string document { get; set; }
    }
    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}