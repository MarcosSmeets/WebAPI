using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Models
{
    public class Player
    {
        public int playerId { get; set; }
        public string playerNick { get; set; }
        public string photoFileName { get; set; }
    }
}
