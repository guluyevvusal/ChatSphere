using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSphere.Domain.Models
{
    public class Message
    {
        public int  Id { get; set; }
        public int SenderId { get; set; }
        public int ChatRoomId { get; set; }
        public string Content { get; set; }
        public DateTime Sentat { get; set; }
    }
}
