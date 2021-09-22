using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Voyance.Models
{
    public class MessageObjectVM<T> where T : class
    {
        public MessageObjectVM()
        {
            ListMessages = new List<MessageVM>();
        }
        public T Object { get; set; }
        public List<MessageVM> ListMessages { get; set; }
        public bool HasError { get; set; }
    }
}
