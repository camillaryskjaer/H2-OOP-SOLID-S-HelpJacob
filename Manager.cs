using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This is the manager class with the main responsibility to manage the other classes
namespace HelpJacob
{
    public class Manager
    {
        //Method to choose the right sender to send the message
        public void SendMessage()
        {
            Message message = new Message("jesper@jespersen.dk", "hans@hansen.hans", "Niels Hansen har en bondegård. I ah I ah oh.", "En lille bondegårds sang", "ole@olesen.ole", true, AllOrOne.one, MessageCarrier.Smtp);
            ConvertToHtml convert = new ConvertToHtml();//Instantiates a new instance of the converter object
            switch (message.Carrier)
            {
                case MessageCarrier.Smtp://If Messagecarrier is smtp
                    if (message.IsHTML)
                        message.Body = convert.Convert(message.Body);//Convert the body
                    SendSmtp sendSmtp = new SendSmtp();//Instantiate a new instance of the SendSmtp

                    switch (message.AllOrOne)//switch if the message is to one or all
                    {
                        case AllOrOne.all:
                            string[] recipients = { message.To };//Add recipants to the array
                            sendSmtp.SendMessageToAll(MessageCarrier.Smtp, recipients, message);//Call the method to send to all in the SendSmtp class
                            break;

                        case AllOrOne.one:
                            sendSmtp.SendMessage(MessageCarrier.Smtp, message);//Call the method to send to one
                            break;
                    }
                    break;


                case MessageCarrier.VMessage://If Messagecarrier is Vmessage
                    if (message.IsHTML)
                        message.Body = convert.Convert(message.Body);//Convert the body
                    SendVmessage sendV = new SendVmessage();//Instantiate a new instance of the SendVmessage

                    switch (message.AllOrOne)//switch if the message is to one or all
                    {
                        case AllOrOne.all:
                            string[] recipients = { message.To };
                            sendV.SendMessageToAll(MessageCarrier.VMessage, recipients, message);//Call the method to send to all in the SendVmessage class
                            break;
                        case AllOrOne.one:
                            sendV.SendMessage(MessageCarrier.VMessage, message);//Call the method to send to one
                            break;
                    }
                    break;
            }
        }
    }
}
