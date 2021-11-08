using System;
using System.Text.Json.Serialization;

namespace DTOs
{
    public class PersonneDTO : IdDTO
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public long? IdAdresse { get; set; }
    }
}