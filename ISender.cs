using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    //This is the sender interface with two methods, to ensure that all classes implementet into this interface has those two classes
    interface ISender
    {
        void SendMessageToAll(Message m);

        void SendMessage(Message m);
    }
}
