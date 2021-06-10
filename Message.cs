using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJacob
{
    //This is tha class containen the message object it is being send to the manager
    public enum MessageCarrier { Smtp, VMessage }
    public enum AllOrOne { all, one }

    public class Message
    {
        //Fields
        private string to, from, body, subject, cc;
        private bool isHTML;
        private AllOrOne allOrOne;
        private MessageCarrier carrier;



        //Properties
        public string To { get => to; set => to = value; }
        public string From { get => from; set => from = value; }
        public string Body { get => body; set => body = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Cc { get => cc; set => cc = value; }
        public bool IsHTML { get =>isHTML; set => isHTML = value; }
        public AllOrOne AllOrOne { get =>allOrOne; set => allOrOne = value; }
        public MessageCarrier Carrier { get =>carrier; set => carrier = value; }



        //Constructor
        public Message(string to, string from, string body, string subject, string cc, bool isHTML, AllOrOne allOrOne, MessageCarrier carrier)
        {
            this.to = to;
            this.from = from;
            this.body = body;
            this.subject = subject;
            this.cc = cc;
            this.isHTML = isHTML;
            this.allOrOne = allOrOne;
            this.carrier = carrier;
        }

    }
}
