using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Messages_Manager
{
    class Messages
    {
        public Messages(int sent, int recieved)
        {
            Sent = sent;
            Recieved = recieved;

        }

        public int Sent { get; set; }
        public int Recieved { get; set; }
    }
}
