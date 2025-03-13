using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSphere.Domain.Models
{
    public class Chatroom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection< Message> Messages { get; set; }
    }
}
