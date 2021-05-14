using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApplication.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public string From { get; set; }
        public string To { get; set; }

    }
}
