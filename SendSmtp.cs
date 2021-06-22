using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    //This class only sends SMTP messages. It is implementet in the ISender Interface
    public class SendSmtp: ISender
    {

        public void SendMessage( Message m)
        {
         
                //her implementeres alt koden til at sende via Smtp
           
        }

        public void SendMessageToAll(Message m)
        {
            
                //her implementeres alt koden til at sende via Smtp
            
        }
    }
}
