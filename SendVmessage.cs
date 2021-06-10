using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    //This class only sends Vmessages. It is implementet in the ISender Interface
    public class SendVmessage :ISender
    {
        //Method to send message to one recipant
        public void SendMessage(MessageCarrier type, Message m)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
              
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {


                //her implementeres alt koden til at sende via VMessage
            }
        }
        //Method to send message to multiple recipents
        public void SendMessageToAll(MessageCarrier type, string[] to, Message m)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {

                //her implementeres alt koden til at sende via Smtp
            }



            if (type.Equals(MessageCarrier.VMessage))
            {

                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
