using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Achor
{
    class Message
    {
        private string messageSender;
        private string messageContent;

        /* ---------BASE-----------
        public string getMessageSender(){
            return this.messageSender;
        }

        public void setMessageSender(string sender){
            this.messageSender = sender;
        }*/

        //---------fomba fanoratana GETTER sy SETTER--------
        /*
            public string MessageContent
            {
                get { return messageContent; }
                set { messageContent = value; }
            }
        */

        //fomba hafa tena conseiller fanoratana GETTER sy SETTER
        public string MyContent 
        { 
            get 
            { 
                return messageContent; 
            }  

            set 
            { 
                messageContent = value; 
            } 
        }

        public string MySender 
        { 
            get 
            { 
                return messageSender; 
            } 

            set 
            { 
                messageSender = value; 
            } 
        }

        public Message(string sender, string content)
        {
            this.messageSender = sender;
            this.messageContent = content;
        }      
    }
}
