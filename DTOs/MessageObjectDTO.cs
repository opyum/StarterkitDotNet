using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTOs
{
    public class MessageObjectDTO<T> where T : class
    {
        /// <summary>
        /// l'object qui doit être retourné par le service
        /// </summary>
        public T Object { get; set; }
        /// <summary>
        /// Message d'erreur ou ok
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// on peut stocker l'exception
        /// </summary>
        public string InnerException { get; set; }
        /// <summary>
        /// le type de message
        /// </summary>
        public SeverityEnum Severity { get; set; }

        /// <summary>
        /// juste pour la lisibilité du code
        /// </summary>
        public bool HasError { get {
                return Severity == SeverityEnum.ERROR;    
            }
        }
    }
}
